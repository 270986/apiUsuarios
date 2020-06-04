using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace apiUsuarios.Models
{
    [Table("USUARIO_APP")]
    public class Usuario
    {     
        [Key]
        public int USUA_CD { get; set; }          
        public string USUA_DS_LOGIN {get ; set; }
        public string USUA_CD_SENHA {get ; set; }
        public string EMAIL {get ; set; }

    }
}