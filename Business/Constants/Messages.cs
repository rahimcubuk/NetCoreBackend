namespace Business.Constants
{
    public static class Messages
    {
        #region Success Messages
        public static string SuccessAdded = "Ekleme Basarili.";
        public static string SuccessUpdated = "Guncelleme Basarili.";
        public static string SuccessDeleted = "Silme basarili.";
        public static string SuccessListed = "Listeleme Basarili.";
        #endregion

        #region Error Messages
        public static string NameInvalidError = "Girilen Ad Gecersiz.";
        public static string MaintenanceTimeError = "Sistem bakimdadir.";
        public static string ErrorAdded = "Ekleme Basarisiz.";
        public static string ErrorUpdated = "Guncelleme Basarisiz.";
        public static string ErrorDeleted = "Silme basarisiz.";
        public static string ErrorListed = "Listeleme Basarisiz.";
        #endregion

        #region Authorization Messages
        public static string AuthorizationDenied = "Yetkilendirme hatasi.";
        public static string UserNotFound = "Kullanici bulunamadi.";
        public static string PasswordError = "Parola hatasi.";
        public static string SuccessfulLogin = "Giris basarili.";
        public static string UserAlreadyExists = "Bu kullanici zaten kayitli.";
        public static string AccessTokenCreated = "Access token olusturuldu.";
        public static string UserRegistered = "Kullanici kaydedildi";
        public static string ClaimsNotFound = "Aranan nitelikte kayit bulunamadi.";
        public static string ClaimAdded = "Yetki Verildi.";
        #endregion
    }
}
