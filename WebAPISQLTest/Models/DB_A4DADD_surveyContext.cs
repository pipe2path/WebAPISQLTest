using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPISQLTest.Models
{
    public partial class DB_A4DADD_surveyContext : DbContext
    {
        public DB_A4DADD_surveyContext()
        {
        }

        public DB_A4DADD_surveyContext(DbContextOptions<DB_A4DADD_surveyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<SurveyResponse> SurveyResponse { get; set; }
        public virtual DbSet<UserCoupon> UserCoupon { get; set; }
        public virtual DbSet<UserResponse> UserResponse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SQL5045.site4now.net;database=DB_A4DADD_survey;User Id=DB_A4DADD_survey_admin;Password=Bombay79;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>(entity =>
            {
                entity.Property(e => e.EntityId).HasColumnName("entityId");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.ContactName)
                    .HasColumnName("contactName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntityName)
                    .HasColumnName("entityName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.MessageId).HasColumnName("messageId");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.DateLastTextSent)
                    .HasColumnName("dateLastTextSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message1)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.QuestionId).HasColumnName("questionId");

                entity.Property(e => e.Choices)
                    .HasColumnName("choices")
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("displayOrder");

                entity.Property(e => e.QuestionDesc)
                    .HasColumnName("questionDesc")
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType)
                    .HasColumnName("questionType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyId).HasColumnName("surveyId");
            });

            modelBuilder.Entity<SurveyResponse>(entity =>
            {
                entity.ToTable("surveyResponse");

                entity.Property(e => e.SurveyResponseId).HasColumnName("surveyResponseId");

                entity.Property(e => e.Choice)
                    .HasColumnName("choice")
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnName("questionId");

                entity.Property(e => e.SurveyId).HasColumnName("surveyId");

                entity.Property(e => e.UserResponseId).HasColumnName("userResponseId");
            });

            modelBuilder.Entity<UserCoupon>(entity =>
            {
                entity.Property(e => e.UserCouponId).HasColumnName("userCouponId");

                entity.Property(e => e.CouponCode).HasColumnName("couponCode");

                entity.Property(e => e.DateGenerated)
                    .HasColumnName("dateGenerated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRedeemed)
                    .HasColumnName("dateRedeemed")
                    .HasColumnType("datetime");

                entity.Property(e => e.MessageText)
                    .HasColumnName("messageText")
                    .IsUnicode(false);

                entity.Property(e => e.UserResponseId).HasColumnName("userResponseId");
            });

            modelBuilder.Entity<UserResponse>(entity =>
            {
                entity.Property(e => e.UserResponseId).HasColumnName("userResponseId");

                entity.Property(e => e.OptIn).HasColumnName("optIn");

                entity.Property(e => e.SurveyId).HasColumnName("surveyId");

                entity.Property(e => e.UserEmail)
                    .HasColumnName("userEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasColumnName("userPhone")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
