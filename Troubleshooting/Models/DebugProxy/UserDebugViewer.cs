namespace Troubleshooting
{
    internal class UserDebugViewer
    {
        #region| Properties |

        public User Usuario { get; set; }

        #endregion

        #region| Constructor |

        public UserDebugViewer(User usuario)
        {
            this.Usuario = usuario;
        } 

        #endregion

        public string NomeCompleto => Usuario.Nome + Usuario.Sobrenome;
    }
}
