﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace midterm.Models
{
    public partial class SE407_BookstoreContext : DbContext
    {
        public SE407_BookstoreContext()
        {
        }

        public SE407_BookstoreContext(DbContextOptions<SE407_BookstoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<TroubleTicket> TroubleTickets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=sql.neit.edu,4500;User Id=SE407_BookStore;Password=B00k$t0r3;Database=SE407_Bookstore;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorFirst).HasMaxLength(50);

                entity.Property(e => e.AuthorLast).HasMaxLength(50);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.BookTitle).HasMaxLength(50);

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookAuthor");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookGenre");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CustomerFirst).HasMaxLength(50);

                entity.Property(e => e.CustomerLast).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.Zip).HasMaxLength(5);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.Property(e => e.GenreType).HasMaxLength(50);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.CheckedIn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckedOutDate).HasColumnType("date");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionBook");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionCustomer");
            });

            modelBuilder.Entity<TroubleTicket>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK__TroubleT__ED7260D9E5667458");

                entity.Property(e => e.TicketId).HasColumnName("Ticket_ID");

                entity.Property(e => e.Category).HasMaxLength(20);

                entity.Property(e => e.CloseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Close_Date");

                entity.Property(e => e.OrigDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Orig_Date");

                entity.Property(e => e.ReportingEmail)
                    .HasMaxLength(75)
                    .HasColumnName("Reporting_Email");

                entity.Property(e => e.ResponderEmail)
                    .HasMaxLength(75)
                    .HasColumnName("Responder_Email");

                entity.Property(e => e.ResponderNotes)
                    .HasColumnType("text")
                    .HasColumnName("Responder_Notes");

                entity.Property(e => e.TicketDesc)
                    .HasColumnType("text")
                    .HasColumnName("Ticket_Desc");

                entity.Property(e => e.TicketTitle)
                    .HasMaxLength(255)
                    .HasColumnName("Ticket_Title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
