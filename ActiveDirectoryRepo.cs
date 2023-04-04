using System;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using LoansApp.Folders;
using System.Globalization;


namespace LoansApp
{
    public class ActiveDirectoryRepo
    {
        private readonly PrincipalContext principal;
        public ActiveDirectoryRepo(PrincipalContext principal)
        {
            this.principal = principal;
        }
        public UserPrincipal CheckIdentityExistById(string id)
        { 

            var identity = UserPrincipal.FindByIdentity(principal, IdentityType.UserPrincipalName, id + "@gov.il");
            if (identity != null) return identity;
            return null; 

        }
        public UserPrincipal CheckIdentityExistByName(string Name)
        { 

            var identity = UserPrincipal.FindByIdentity(principal, IdentityType.Name, Name);
            if (identity != null) return identity;
            return null; 

        }
        public UserPrincipal CheckIdentityExistByUserName(string Name)
        { 

            var idenntity = UserPrincipal.FindByIdentity(principal, IdentityType.SamAccountName, Name);
            if (idenntity != null) return idenntity;
            return null; 

        } 
        public bool CheckUser(string userName)
        { 

            UserPrincipal usr = UserPrincipal.FindByIdentity(principal, userName);
            if (usr != null)
            {
                return true;
            } 

            return false; 
        } 
        public UserPrincipal AssociateUserProduct(UserPrincipal user, int days)
        { 

            UserPrincipal usr = UserPrincipal.FindByIdentity(principal, IdentityType.SamAccountName, user.SamAccountName); 
            if (usr == null)
             {
                MessageBox.Show("משתמש לא נמצא באקטיב");
                return null;
             }
            else
            {
                try
                {
                    usr.AccountExpirationDate = DateTime.Now.AddDays(days);
                    usr.Save();
                } 
                catch (Exception ex)
                {
                    MessageBox.Show($"הייתה בעיה בעדכון המשתמש באקטיב : {ex.Message}");
                    return null;
                }
                return usr; 

            }
        }
        public UserPrincipal DisconnectUserProduct(UserPrincipal user, BindingList<Product> Products)
        {

            UserPrincipal usr = UserPrincipal.FindByIdentity(principal, IdentityType.SamAccountName, user.SamAccountName);
            if (usr == null)
            {
                MessageBox.Show("משתמש לא נמצא באקטיב");
                return null;
            }

            else
            {
                try
                {
                    string split = usr.UserPrincipalName.Split("@gov.il".ToCharArray())[0];
                    DateTime maxDate = DateTime.ParseExact("24/12/9999", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    foreach (Product product in Products)
                    {

                        if (product.UserId.Equals(split) && maxDate > DateTime.ParseExact(product.EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                        {
                            maxDate = DateTime.ParseExact(product.EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        }
                        
                    }
                    if (maxDate == DateTime.ParseExact("24/12/9999", "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    {
                        usr.AccountExpirationDate = null;
                    }
                    else
                    {
                        usr.AccountExpirationDate = maxDate;
                    }
                    usr.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"הייתה בעיה בעדכון המשתמש באקטיב: {ex.Message}");
                    
                    return null;
                }
                return usr;

            }
            
        } 
        public UserPrincipal ExtensionProduct (UserPrincipal user, int days)
        { 

            UserPrincipal usr = UserPrincipal.FindByIdentity(principal, IdentityType.SamAccountName, user.SamAccountName); 
            if (usr == null)
            { 
                MessageBox.Show("המשתמש לא נמצא באקטיב");
                return null; 
            } 
            else
            {
                try
                {
                    usr.AccountExpirationDate = DateTime.Now.AddDays(days);
                    usr.Save();
                } 
                catch (Exception ex)
                {
                    MessageBox.Show($"הייתה בעיה בעדכון המשתמש באקטיב:{ex.Message}");
                    return null;
                }
                return usr;
            } 
        }
    }
}
