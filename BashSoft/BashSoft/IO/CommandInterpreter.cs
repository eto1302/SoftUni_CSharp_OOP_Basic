using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BashSoft.Exceptions;
using BashSoft.IO.Commands;

namespace BashSoft
{
    public class CommandInterpreter
    {
        private Tester judge;
        private StudentsRepository repository;
        private IOManager inputOutputManager;

        public CommandInterpreter(Tester judge, StudentsRepository repository, IOManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }
        public void InterpredCommand(string input)
        {
            string[] data = input.Split(' ');
            string commandName = data[0];
            commandName = commandName.ToLower();
            try
            {
                Command command = this.ParseCommand(input, commandName, data);
                command.Execute();
                
            }
            catch (ArgumentNullException ae)
            {
                OutputWriter.DisplayException(ae.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                OutputWriter.DisplayException(dnfe.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                OutputWriter.DisplayException(aoore.Message);
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }

        }

        private Command ParseCommand(string input, string command, string[] data)
        {
            switch (command)
            {
                
                case "open":
                    return new OpenFileCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                    
                case "mkdir":
                   return new MakeDirectoryCommand(input,data,judge,repository,inputOutputManager);
                case "help":
                    return new GetHelpCommand(input,data,judge,repository,inputOutputManager);
                case "ls":
                    return new TraverseFoldersCommand(input,data,judge,repository,inputOutputManager);
                    
                case "cmp":
                    return new CompareFilesCommand(input,data,judge,repository,inputOutputManager);
                    
                case "cdrel":
                    return new ChangeRelativePathCommand(input,data,judge,repository,inputOutputManager);
                    
                case "cdabs":
                    return new ChangeAbsolutePathCommand(input, data, judge, repository, inputOutputManager);
                    
                case "readdb":
                    return new ReadDatabaseCommand(input,data,judge,repository,inputOutputManager);
                    
                case "filter":
                    return new PrintFilteredStudentsCommand(input, data, judge, repository, inputOutputManager);
                case "order":
                    return new PrintOrderedStudentsCommand(input,data,judge,repository,inputOutputManager);
                case "show":
                    return new ShowCourseCommand(input,data,judge,repository,inputOutputManager);
                case "dropdb":
                    return new DropDatabaseCommand(input,data,judge,repository,inputOutputManager);
                default:
                    throw new InvalidCommandException(input);

            }
        }
    }
}
