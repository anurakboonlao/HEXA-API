using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DuplicateCaseResponseModel
    {
        public bool IsPass { get; set; }
        public string ErrorMessage { get; set; }
        public int ResultCaseId { get; set; }

        public DuplicateCaseResponseModel()
        {

        }

        public DuplicateCaseResponseModel(bool isPass, string errorMessage, int caseId)
        {
            IsPass = isPass;
            ErrorMessage = errorMessage;
            ResultCaseId = caseId;
        }
    }
}
