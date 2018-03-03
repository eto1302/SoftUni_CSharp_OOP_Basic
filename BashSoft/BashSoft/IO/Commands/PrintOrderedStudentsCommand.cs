using System;
using System.Collections.Generic;
using System.Text;
using BashSoft.Exceptions;

namespace BashSoft.IO.Commands
{
    class PrintOrderedStudentsCommand : Command
    {
        public PrintOrderedStudentsCommand(string input, string[] data, Tester judge, StudentsRepository repository,
            IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
            
        }

        public override void Execute()
        {
            if (this.Data.Length != 5)
            {
                throw new InvalidCommandException(this.Input);
            }
            string courseName = this.Data[1];
            string filter = this.Data[2].ToLower();
            string orderCommand = this.Data[3].ToLower();
            string orderQuantity = this.Data[4].ToLower();
            TryParseParametersForOrderAndTake(orderCommand, orderQuantity, courseName, filter);
        }

        private void TryParseParametersForOrderAndTake(string orderCommand, string orderQuantity, string courseName,
            string filter)
        {
            if (orderCommand == "take")
            {
                if (orderQuantity == "all")
                {
                    this.Repository.OrderAndTake(courseName, filter, null);
                }
                else
                {
                    int studentsToOrder;
                    bool hasParsed = int.TryParse(orderQuantity, out studentsToOrder);
                    if (hasParsed)
                    {
                        this.Repository.OrderAndTake(courseName, filter, studentsToOrder);
                    }
                    else
                    {
                        OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
                    }
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
            }
        }
    }
}
