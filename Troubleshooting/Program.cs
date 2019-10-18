#define local

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Troubleshooting
{
    class Program
    {
        #region| Properties |

        private static string BR => Environment.NewLine;

        #endregion

        #region| Entrypoint |

        static void Main(string[] args)
        {
            // Exemplo de execução de metodo usando o Conditional attribute
            HelloDeveloper();

            // Este exemplo mostra como pegar o nome do metodo que invokou outro metodo, line e nome do arquivo físico
            LogMessage("Iniciando os testes");

            // Executará o código dentro deste IF se o debug estiver sendo realizado
            if (Debugger.IsAttached)
            {
                Console.WriteLine("Esta mensagem somente será exibida em modo de debug" + BR);
            }

            // Exemplo usando pre-processor directives
            #if local
            Console.WriteLine("Esta mensagem foi exibida pois existe uma diretiva 'local' definida" + BR);
            #endif

            // Exibirá a mensagem no output window do Visual Studio
            Debug.WriteLine("Iniciou o debug");

            // Instanciando um usuário para ver o exemplo usando DebuggerDisplay e DebuggerTypeProxy
            var user = GetUser();

            // Exibirá uma mensagem se a condicional for verdadeira
            Debug.WriteLineIf(user != null, "O usuário está corretamente instanciado:" + user.Nome);

            // Este comando sempre irá parar a execução nesta linha11 independente de ter breakpoint ou não
            Debugger.Break();

        } 

        #endregion

        #region| Methods |

        /// <summary>
        /// Exemplo de execução condicional usando conditional compilation symbols
        /// </summary>
        [Conditional("DEV")]
        static void HelloDeveloper()
        {
            Console.WriteLine("Hello developers, welcome onboard" + BR);
        }

        /// <summary>
        /// Exemplo de execução condicional usando conditional compilation symbols
        /// </summary>
        static void LogMessage(string message, [CallerFilePath] string filePath= "", [CallerMemberName] string methodName = "", [CallerLineNumber] int line = 0)
        {
            Debug.Indent();
            Debug.WriteLine(" ");

            Console.WriteLine($"Log Message: {message}");
            Console.WriteLine($"Details:{filePath}, {methodName} @ line:{line}");

            Debug.Unindent();
            Debug.WriteLine(" ");
        }

        /// <summary>
        /// Metodo que retorna uma instancia do usuario
        /// </summary>
        /// <returns>User</returns>
        static User GetUser()
        {
            var output = new User()
            {
                ID        = 0,
                Nome      = "Jose Carlos",
                Sobrenome = "de Jesus Junior",
                Idade     = 40,
                Altura    = 1.90,
                Peso      = 118.7
            };

            return output;

        }

        /// <summary>
        /// Exibe uma mensagem na console application
        /// </summary>
        /// <param name="message">message to be displayed</param>
        static void Print(string message)
        {
            message.Print();
        }

        /// <summary>
        /// Exibe uma mensagem na output window do Visual Studio
        /// </summary>
        /// <param name="message">message to be displayed</param>
        static void Output(string message)
        {
            message.Output();
        }

        #endregion
    }
}
