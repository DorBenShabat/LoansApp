using System;
using System.DirectoryServices.AccountManagement;
using System.Windows;

namespace Loans
{
    public class ActiveDirectory
    {
        private readonly PrincipalContext principal;
        public ActiveDirectory (PrincipalContext principal)
        {
            this.principal = principal;
        } 
        public UserPrincipal CheckIdentityExistById (string id) 
        {
            var identity = UserPrincipal.FindByIdentity(principal, IdentityType.UserPrincipalName, id + "@gov.il");
            if (identity != null) return identity;
            return null;
        } 
        public UserPrincipal CheckIdentityExistByName (string Name)
        {
            var identity = UserPrincipal.FindByIdentity(principal, IdentityType.Name, Name);
            if (identity != null) return identity;
            return null;
        } 
        public UserPrincipal CheckIdentityExistByUserName (string name)
        {
            var idenntity = UserPrincipal.FindByIdentity(principal, IdentityType.SamAccountName, name);
            if (idenntity != null) return idenntity;
            return null; 
        }  
        public UserPrincipal MemberTakeProducts (UserPrincipal user, int days)
        {
            UserPrincipal usr = UserPrincipal.FindByIdentity(principal, IdentityType.SamAccountName,  user.SamAccountName); 
            if (usr == null )
            { 
                
                return null;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
}
