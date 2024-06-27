namespace Instagram.Data
{
    public class UtenteRoles
    {
        public int Id { get; set; }
        public int UtenteId { get; set; }
        public Utente Utente { get; set; }
        public int RoleId { get; set; }
        public Roles Roles { get; set; }
        public UtenteRoles() { }
        public UtenteRoles(int id, int utenteId, Utente utente, int roleId, Roles roles)
        {
            Id = id;
            UtenteId = utenteId;
            Utente = utente;
            RoleId = roleId;
            Roles = roles;
        }
    }
}
