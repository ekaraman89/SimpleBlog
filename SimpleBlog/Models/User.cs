using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    public class User
    {
        public virtual int ID { get; set; }
        public virtual string Username { get; set; }
        public virtual string Mail { get; set; }
        public virtual string PasswordHash { get; set; }
    }

    public class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Table("Users");
            Id(x => x.ID, x => x.Generator(Generators.Identity));
            Property(x => x.Username, x => x.NotNullable(true));
            Property(x => x.Mail, x => x.NotNullable(true));

            Property(x => x.PasswordHash, x =>
            {
                x.Column("Password_Hash");
                x.NotNullable(true);
            }
            );

        }
    }
}