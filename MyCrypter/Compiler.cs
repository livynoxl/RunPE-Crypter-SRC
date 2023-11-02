using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace MyCrypter
{
    class Compiler
    {

        public static void CodeDom(string Src, string Path)
        {
            if (Src.Length > 0 && Path.Length > 0)
            {
                try
                {
                    Dictionary<string, string> Dic = new Dictionary<string, string>();
                    Dic.Add("CompilerVersion", "v3.5");
                    CSharpCodeProvider CSharpCompiler = new CSharpCodeProvider(Dic);
                    CompilerParameters CompilerParams = new CompilerParameters();
                    CompilerParams.ReferencedAssemblies.AddRange(new string[] { "System.dll", "mscorlib.dll", "System.Windows.Forms.dll", "Microsoft.VisualBasic.dll" });
                    CompilerParams.IncludeDebugInformation = false;
                    CompilerParams.GenerateInMemory = false;
                    CompilerParams.GenerateExecutable = true;
                    CompilerParams.OutputAssembly = Path;
                    CompilerParams.CompilerOptions += "/platform:X86 /unsafe /target:winexe";
                    CompilerResults Result = CSharpCompiler.CompileAssemblyFromSource(CompilerParams, Src);
                    string message = "File encrypted successfully!";
                    string title = "Success";
                    MessageBox.Show(message, title);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: {ex.Message}", "Compiling Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
