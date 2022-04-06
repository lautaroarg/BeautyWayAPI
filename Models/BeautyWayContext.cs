using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BeautyWayAPI.Models
{
    public partial class BeautyWayContext : DbContext
    {
        public BeautyWayContext()
        {
        }

        public BeautyWayContext(DbContextOptions<BeautyWayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<ContactUser> ContactUsers { get; set; } = null!;
        public virtual DbSet<Favorite> Favorites { get; set; } = null!;
        public virtual DbSet<Like> Likes { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<StatusComment> StatusComments { get; set; } = null!;
        public virtual DbSet<StatusFavorite> StatusFavorites { get; set; } = null!;
        public virtual DbSet<StatusLike> StatusLikes { get; set; } = null!;
        public virtual DbSet<StatusPost> StatusPosts { get; set; } = null!;
        public virtual DbSet<StatusUser> StatusUsers { get; set; } = null!;
        public virtual DbSet<TypeOfLike> TypeOfLikes { get; set; } = null!;
        public virtual DbSet<TypeOfPost> TypeOfPosts { get; set; } = null!;
        public virtual DbSet<TypeUser> TypeUsers { get; set; } = null!;
        public virtual DbSet<UbicationUser> UbicationUsers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersCustomer> UsersCustomers { get; set; } = null!;
        public virtual DbSet<UsersProfessional> UsersProfessionals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-UQ0K52S\\SQLEXPRESS;Database=BeautyWay;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Comment");

                entity.Property(e => e.DateComment)
                    .HasColumnType("date")
                    .HasColumnName("dateComment");

                entity.Property(e => e.IdComment)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idComment");

                entity.Property(e => e.IdPost).HasColumnName("idPost");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.ImageComment).HasColumnName("imageComment");

                entity.Property(e => e.StatusComment).HasColumnName("statusComment");

                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Posts");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Users");

                entity.HasOne(d => d.StatusCommentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StatusComment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_StatusComment");
            });

            modelBuilder.Entity<ContactUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.PhoneUser)
                    .HasMaxLength(20)
                    .HasColumnName("phoneUser");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactUsers_Users");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdFavorite)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idFavorite");

                entity.Property(e => e.IdUserCustomer).HasColumnName("idUserCustomer");

                entity.Property(e => e.IdUserProfessional).HasColumnName("idUserProfessional");

                entity.Property(e => e.StatusFavorite).HasColumnName("statusFavorite");

                entity.HasOne(d => d.IdUserCustomerNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUserCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorites_UsersCustomers");

                entity.HasOne(d => d.IdUserProfessionalNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUserProfessional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorites_UsersProfessionals");

                entity.HasOne(d => d.StatusFavoriteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StatusFavorite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorites_StatusFavorite");
            });

            modelBuilder.Entity<Like>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Like");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.IdLike)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idLike");

                entity.Property(e => e.IdPost).HasColumnName("idPost");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.StatusLike).HasColumnName("statusLike");

                entity.Property(e => e.TypeOfLike).HasColumnName("typeOfLike");

                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Like_Posts");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Like_Users");

                entity.HasOne(d => d.StatusLikeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StatusLike)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Like_StatusLike");

                entity.HasOne(d => d.TypeOfLikeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TypeOfLike)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Like_TypeOfLike");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.IdPost);

                entity.Property(e => e.IdPost)
                    .ValueGeneratedNever()
                    .HasColumnName("idPost");

                entity.Property(e => e.AudioPost).HasColumnName("audioPost");

                entity.Property(e => e.DatePost)
                    .HasColumnType("date")
                    .HasColumnName("datePost");

                entity.Property(e => e.IdProfessional).HasColumnName("idProfessional");

                entity.Property(e => e.IdTypeOfPost).HasColumnName("idTypeOfPost");

                entity.Property(e => e.ImagePost)
                    .HasColumnType("image")
                    .HasColumnName("imagePost");

                entity.Property(e => e.StatusPost).HasColumnName("statusPost");

                entity.Property(e => e.TextPost).HasColumnName("textPost");

                entity.Property(e => e.VideoPost).HasColumnName("videoPost");

                entity.HasOne(d => d.IdProfessionalNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.IdProfessional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_UsersProfessionals");

                entity.HasOne(d => d.IdTypeOfPostNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.IdTypeOfPost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_TypeOfPost");

                entity.HasOne(d => d.StatusPostNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.StatusPost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_StatusPost");
            });

            modelBuilder.Entity<StatusComment>(entity =>
            {
                entity.HasKey(e => e.IdStatusComment);

                entity.ToTable("StatusComment");

                entity.Property(e => e.IdStatusComment).HasColumnName("idStatusComment");

                entity.Property(e => e.NameStatusComment)
                    .HasMaxLength(20)
                    .HasColumnName("nameStatusComment");
            });

            modelBuilder.Entity<StatusFavorite>(entity =>
            {
                entity.HasKey(e => e.IdStatusFavorite);

                entity.ToTable("StatusFavorite");

                entity.Property(e => e.IdStatusFavorite).HasColumnName("idStatusFavorite");

                entity.Property(e => e.NameStatusFavorite)
                    .HasMaxLength(15)
                    .HasColumnName("nameStatusFavorite");
            });

            modelBuilder.Entity<StatusLike>(entity =>
            {
                entity.HasKey(e => e.IdStatusLike);

                entity.ToTable("StatusLike");

                entity.Property(e => e.IdStatusLike).HasColumnName("idStatusLike");

                entity.Property(e => e.NameStatusLike)
                    .HasMaxLength(20)
                    .HasColumnName("nameStatusLike");
            });

            modelBuilder.Entity<StatusPost>(entity =>
            {
                entity.HasKey(e => e.IdStatusPost);

                entity.ToTable("StatusPost");

                entity.Property(e => e.IdStatusPost).HasColumnName("idStatusPost");

                entity.Property(e => e.NameStatusPost)
                    .HasMaxLength(20)
                    .HasColumnName("nameStatusPost");
            });

            modelBuilder.Entity<StatusUser>(entity =>
            {
                entity.HasKey(e => e.IdStatusUser);

                entity.Property(e => e.IdStatusUser).HasColumnName("idStatusUser");

                entity.Property(e => e.NameStatus)
                    .HasMaxLength(20)
                    .HasColumnName("nameStatus");
            });

            modelBuilder.Entity<TypeOfLike>(entity =>
            {
                entity.HasKey(e => e.IdTypeOfLike);

                entity.ToTable("TypeOfLike");

                entity.Property(e => e.IdTypeOfLike).HasColumnName("idTypeOfLike");

                entity.Property(e => e.NameTypeOfLike)
                    .HasMaxLength(20)
                    .HasColumnName("nameTypeOfLike");
            });

            modelBuilder.Entity<TypeOfPost>(entity =>
            {
                entity.HasKey(e => e.IdTypeOfPost);

                entity.ToTable("TypeOfPost");

                entity.Property(e => e.IdTypeOfPost).HasColumnName("idTypeOfPost");

                entity.Property(e => e.NameTypeOfPost)
                    .HasMaxLength(50)
                    .HasColumnName("nameTypeOfPost");
            });

            modelBuilder.Entity<TypeUser>(entity =>
            {
                entity.HasKey(e => e.IdTypeOfUser);

                entity.Property(e => e.IdTypeOfUser).HasColumnName("idTypeOfUser");

                entity.Property(e => e.NameType)
                    .HasMaxLength(10)
                    .HasColumnName("nameType")
                    .IsFixedLength();
            });

            modelBuilder.Entity<UbicationUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Apartment)
                    .HasMaxLength(50)
                    .HasColumnName("apartment");

                entity.Property(e => e.Flat)
                    .HasMaxLength(50)
                    .HasColumnName("flat");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Neighborhood)
                    .HasMaxLength(50)
                    .HasColumnName("neighborhood");

                entity.Property(e => e.Numeration)
                    .HasMaxLength(50)
                    .HasColumnName("numeration");

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .HasColumnName("street");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UbicationUsers_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emailUser");

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(8)
                    .HasColumnName("passwordUser");

                entity.Property(e => e.StatusUser).HasColumnName("statusUser");

                entity.Property(e => e.TypeOfUser).HasColumnName("typeOfUser");

                entity.HasOne(d => d.StatusUserNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.StatusUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_StatusUsers");

                entity.HasOne(d => d.TypeOfUserNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TypeOfUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_TypeUsers");
            });

            modelBuilder.Entity<UsersCustomer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.GenereCustomer)
                    .HasMaxLength(15)
                    .HasColumnName("genereCustomer");

                entity.Property(e => e.IdTypeOfUser).HasColumnName("idTypeOfUser");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.LastnameCustomer)
                    .HasMaxLength(50)
                    .HasColumnName("lastnameCustomer");

                entity.Property(e => e.NameCustomer)
                    .HasMaxLength(50)
                    .HasColumnName("nameCustomer");

                entity.Property(e => e.NroIdentification)
                    .HasMaxLength(10)
                    .HasColumnName("nroIdentification");

                entity.Property(e => e.PhotoCustomer)
                    .HasColumnType("image")
                    .HasColumnName("photoCustomer");

                entity.HasOne(d => d.IdTypeOfUserNavigation)
                    .WithMany(p => p.UsersCustomers)
                    .HasForeignKey(d => d.IdTypeOfUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersCustomers_TypeUsers");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UsersCustomers)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersCustomers_Users");
            });

            modelBuilder.Entity<UsersProfessional>(entity =>
            {
                entity.HasKey(e => e.IdProfessional);

                entity.Property(e => e.IdProfessional).HasColumnName("idProfessional");

                entity.Property(e => e.GenereProfessional)
                    .HasMaxLength(20)
                    .HasColumnName("genereProfessional");

                entity.Property(e => e.IdTypeOfUser).HasColumnName("idTypeOfUser");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.LastnameProfessional)
                    .HasMaxLength(30)
                    .HasColumnName("lastnameProfessional");

                entity.Property(e => e.Modality)
                    .HasMaxLength(20)
                    .HasColumnName("modality");

                entity.Property(e => e.NameCompany)
                    .HasMaxLength(50)
                    .HasColumnName("nameCompany");

                entity.Property(e => e.NameProfessional)
                    .HasMaxLength(30)
                    .HasColumnName("nameProfessional");

                entity.Property(e => e.PhotoProfessional)
                    .HasColumnType("image")
                    .HasColumnName("photoProfessional");

                entity.Property(e => e.WorkingDay)
                    .HasMaxLength(30)
                    .HasColumnName("workingDay");

                entity.Property(e => e.WorkingHours)
                    .HasMaxLength(30)
                    .HasColumnName("workingHours");

                entity.HasOne(d => d.IdTypeOfUserNavigation)
                    .WithMany(p => p.UsersProfessionals)
                    .HasForeignKey(d => d.IdTypeOfUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersProfessionals_TypeUsers");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UsersProfessionals)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersProfessionals_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
