using System;
using System.Collections.Generic;
using System.Text;
using BashSoft.Exceptions;

namespace BashSoft.IO.Commands
{
    class ChangeAbsolutePathCommand : Command
    {
        public ChangeAbsolutePathCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)

        {

        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            
                this.InputOutputManager.ChangeCurrrentDirectoryAbsolute(this.Data[1]);
            
        }
    }
}
