using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect_Stone_Romeo
{
    public interface IUtilisateur
    {
        string Mail { get; set; }
        string Mdp { get; set; }
        string Prenom {  get; set; }
    
    }
}
