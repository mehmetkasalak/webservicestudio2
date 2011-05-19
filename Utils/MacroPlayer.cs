using System;
using System.Text.RegularExpressions;
using WebServiceStudio.Dialogs;
using System.IO;
using System.Windows.Forms;

namespace WebServiceStudio.Utils
{
    public class MacroPlayer
    {
        public delegate void MacroCallbackType();
        public enum Commands { WSDL, INVOKE, SET, COPY, LOGC, LOGT, LOGO, GOTO, IFGOTO, ALERT };
        public enum Trees { INPUT, OUTPUT, METHODS };
        private NewMainForm form;
        private string[] tokens;
        private string fileName;
        private string gotoLabel;
        private StreamWriter fileOutput;
        private Commands? command = null;
        private int nextTokenIndex;

        public MacroPlayer(NewMainForm mainForm, string file)
        {
            form = mainForm;
            fileName = file;
            string text = System.IO.File.ReadAllText(fileName);
            tokens = Regex.Split(text, @"\s+");
        }

        public void Play()
        {
            Play(0);
        }

        private void Play(int fromIndex)
        {
            MacroCallbackType callback = new MacroCallbackType(this.MacroCallback);
            try
            {
                for (int i = fromIndex; i < tokens.Length; i++)
                {
                    if (string.IsNullOrEmpty(tokens[i]))
                        continue;

                    if (!string.IsNullOrEmpty(gotoLabel))
                    {
                        if (gotoLabel.Equals(tokens[i]))
                            gotoLabel = string.Empty;
                        continue;
                    }

                    switch (command)
                    {
                        case null:
                            if (Enum.IsDefined(typeof(Commands), tokens[i]))
                            {
                                command = Enum.Parse(typeof(Commands), tokens[i], true) as Commands?;
                            }
                            break;
                        case Commands.WSDL:
                            nextTokenIndex = i + 1;
                            command = null;
                            form.macroPlayGetWsdl(tokens[i], callback);
                            return;
                        case Commands.INVOKE:
                            nextTokenIndex = i + 1;
                            command = null;
                            form.macroPlayInvoke(tokens[i], callback);
                            return;
                        case Commands.SET:
                            nextTokenIndex = i + 3;
                            command = null;
                            if ((i + 2) < tokens.Length)
                            {
                                form.macroPlaySetInput(tokens[i], tokens[i + 1], tokens[i + 2], callback);
                            }
                            return;
                        case Commands.COPY:
                            nextTokenIndex = i + 4;
                            command = null;
                            if ((i + 3) < tokens.Length)
                            {
                                form.macroPlayCopy(tokens[i], tokens[i + 1], tokens[i + 2], tokens[i + 3], callback);
                            }
                            return;
                        case Commands.IFGOTO:
                            nextTokenIndex = i + 4;
                            command = null;
                            if ((i + 3) < tokens.Length)
                            {
                                if (form.macroPlayTest(tokens[i], tokens[i + 1], tokens[i + 2]))
                                {
                                    gotoLabel = tokens[i + 3];
                                }
                            }
                            i += 3;
                            continue;
                        case Commands.GOTO:
                            nextTokenIndex = i + 1;
                            command = null;
                            gotoLabel = tokens[i];
                            continue;
                        case Commands.ALERT:
                            nextTokenIndex = i + 1;
                            command = null;
                            MessageBox.Show(tokens[i], "WSS2 Macro: " + fileName);
                            continue;
                        case Commands.LOGC:
                            nextTokenIndex = i + 1;
                            command = null;
                            saveLog(tokens[i]);
                            continue;
                        case Commands.LOGT:
                            nextTokenIndex = i + 1;
                            command = null;
                            if (Enum.IsDefined(typeof(Trees), tokens[i]))
                            {
                                saveLog((Trees)Enum.Parse(typeof(Trees), tokens[i]));
                            }
                            continue;
                        case Commands.LOGO:
                            nextTokenIndex = i + 2;
                            command = null;
                            if ((i + 1) < tokens.Length)
                            {
                                string s = form.macroPlayLogO(tokens[i], tokens[i + 1]);
                                saveLog(s);
                            }
                            i++;
                            continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Macro failed" + Environment.NewLine + ex.Message);
            }
            if (fileOutput != null)
                fileOutput.Close();
            nextTokenIndex = int.MaxValue;
            form.macroResetCallback();
        }

        private void saveLog(Trees trees)
        {
            saveLog(form.macroPlayLogT(trees));
        }

        private void saveLog(string p)
        {
            logFile().WriteLine(p);
        }

        private StreamWriter logFile()
        {
            lock (form)
            {
                if (fileOutput == null)
                {
                    string p = string.Format("{0}.{1:yyyyMMddHHmmssff}.log", fileName, DateTime.Now);
                    fileOutput = System.IO.File.CreateText(p);
                    fileOutput.AutoFlush = true;
                }
            }
            return fileOutput;
        }

        private void MacroCallback()
        {
            Play(nextTokenIndex);
        }
    }
}
