namespace ky.Entities
{
    public  class User
    {
        public int Id { get; set; }

        public string Fullname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Tel { get; set; }


        public string? Address { get; set; }

        public string Role { get; set; } = null!;

        public byte[] PasswordSalt { get; set; } = null!;

        public byte[] PasswordHash { get; set; } = null!;

        public string? RefreshToken { get; set; }
        public bool IsVerified { get; set; }

        public DateTime? TokenCreated { get; set; }

        public DateTime? TokenExpired { get; set; }

        public string? PasswordResetToken { get; set; }

        public DateTime? ResetTokenExpires { get; set; }

    }
}
