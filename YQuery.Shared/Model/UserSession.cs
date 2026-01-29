namespace YQuery.Shared.Model
{
    public class UserSession
    {
        public string? ServerName { get; private set; }
        public string? DatabaseName { get; private set; }
        public string? UserId { get; private set; }
        public string? Password { get; private set; }

        public bool HasCredentials =>
                !string.IsNullOrEmpty(ServerName) &&
                !string.IsNullOrEmpty(UserId) &&
                !string.IsNullOrEmpty(Password);

        public void SetCredentials(DBCredentials pDBCredentials, bool overwrite = false)
        {
            if (!overwrite && HasCredentials)
                return;

            ServerName = pDBCredentials.SeverName;
            DatabaseName = pDBCredentials.DatabaseName;
            UserId = pDBCredentials.UserId;
            Password = pDBCredentials.Password;
        }


        public void Clear()
        {
            ServerName = null;
            DatabaseName = null;
            UserId = null;
            Password = null;
        }

        public DBCredentials GetDBCredentials()
        {
            return new DBCredentials
            {
                SeverName = this.ServerName,
                DatabaseName = this.DatabaseName,
                UserId = this.UserId,
                Password = this.Password
            };
        }

    }
}
