using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ReportService
{
    //Asso callback contract with service contract usindg CallbackContract attribute
    [ServiceContract(CallbackContract = typeof(IReportServiceCallback))]
    public interface IReportService
    {
        //since we have not set IsOneway=true, the operation is a Request/Reply operation
        [OperationContract]
        void ProcessReport();
    }
    //this is a callback contract
    public interface IReportServiceCallback
    {
        //since we have not set IsOneway=true, the operation is a Request/Reply operation
        [OperationContract]
        void Progress(int percentageCompleted);
    }
}
