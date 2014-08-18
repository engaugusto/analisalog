using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace AnalisaLog
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDir.Text))
                fbdDir.SelectedPath = txtDir.Text;

            fbdDir.ShowDialog();

            if (string.IsNullOrEmpty(fbdDir.SelectedPath))
            {
                MessageBox.Show("Não foi selecionado nenhum diretório");
            }

            txtDir.Text = fbdDir.SelectedPath;

        }

        void ProcessaLog(string[] files)
        {
            Dictionary<string, ItemDic> dicIp = new Dictionary<string, ItemDic>();
            string[] lines;
            List<string> output;
            string fileTmp = string.Empty;
            Regex reg = new Regex(@"\d+\.\d+\.\d+\.\d+", RegexOptions.IgnorePatternWhitespace);
            foreach (var file in files)
            {
                lines = File.ReadAllLines(file);
                foreach (var line in lines)
                {
                    string[] split = line.Split(char.Parse(txtSeparador.Text)) ;//.Split(' ');
                    if (split.Length <= 2)
                    {
                        continue;
                    }
                    
                    //indice da coluna
                    int indice = Convert.ToInt32(txtColIP.Text);

                    string ip = split[indice-1];
                    output = new List<string>();
                    if (reg.IsMatch(ip))
                    {
                        string key = ip+file;
                        if ((!ip.StartsWith(txtIP.Text) || dicIp.ContainsKey(key)))
                        {
                            continue;
                        }
                        if (!dicIp.ContainsKey(key))
                        {
                            output = new List<string>() { line };
                            fileTmp = file;
                            ItemDic novoItem = new ItemDic();
                            novoItem.IP = ip;
                            novoItem.Line = output;
                            novoItem.File = file;
                            dicIp.Add(key, novoItem);
                        }
                        else
                        {
                            ItemDic itemGet = dicIp[key];
                            itemGet.Line.Add(line);
                            itemGet.IP = ip;
                            itemGet.File = file;
                            
                        }
                    }
                }
            }
            ProcessaCSV(dicIp);
        }

        void ProcessaCSV(Dictionary<string, ItemDic> dic)
        {
            string output = string.Empty;
            string concatColumn = string.Empty;
            string[] split = null;
            string keyText = string.Empty;
            
            var r = dic.Values.GroupBy(x=>x.IP).ToList();

            string oldIp = "";
            foreach (var item in r)
            {
                foreach (var item2 in dic.Where(x => x.Value.IP == item.Key).ToList() )
                {
                    if (oldIp != item2.Value.IP)
                    {
                        if (oldIp != string.Empty)
                        {
                            output += Environment.NewLine;
                            output += Environment.NewLine;
                        }
                        output += item2.Value.IP;
                    }
                    output += Environment.NewLine;
                    output += item2.Value.File; 
                    output += Environment.NewLine;
                    output += item2.Value.Line.Aggregate((m,n)=> m + Environment.NewLine + n);
                    

                    oldIp = item2.Value.IP;
                }
            }

            GravaCSV(output);
        }

        private void GravaCSV(string output)
        {
            string file = "log_processado_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".csv";
            file = Path.Combine(txtOutputPath.Text, file);

            File.WriteAllText(file, output);

        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtOutputPath.Text))
                fbdOutput.SelectedPath = txtOutputPath.Text;

            fbdOutput.ShowDialog();

            if (string.IsNullOrEmpty(fbdOutput.SelectedPath))
            {
                MessageBox.Show("Não foi selecionado nenhum diretório");
            }

            string path = fbdOutput.SelectedPath;
            if (txtOutputPath.Text != string.Empty)
            {
                path = txtOutputPath.Text;
            }

            txtOutputPath.Text = path;

        }

        private void btnProcessa_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(fbdOutput.SelectedPath))
            //{
            //    MessageBox.Show("Não foi selecionado nenhum diretório de output");
            //}

            //if (string.IsNullOrEmpty(fbdDir.SelectedPath))
            //{
            //    MessageBox.Show("Não foi selecionado nenhum diretório de log");
            //}

            string path = fbdDir.SelectedPath;
            if (txtDir.Text != string.Empty)
            {
                path = txtDir.Text ;
            }

            string[] files = Directory.GetFiles(path);
            try
            {
                ProcessaLog(files);
                MessageBox.Show("Processado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro genérico. Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

    }

    public class ItemDic
    {
        public ItemDic()
        {
            Line = new List<string>();
        }
        public string IP { get; set; }
        public List<string> Line { get; set; }
        public string File { get; set; }

        public List<char> Files { get; set; }
    }
}
