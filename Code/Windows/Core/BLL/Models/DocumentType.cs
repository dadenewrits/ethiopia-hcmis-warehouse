
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;

namespace BLL
{
    public class DocumentType : _DocumentType
    {
        public DocumentType()
        {

        }

        public static DocumentType documentTypes= new DocumentType();

        private DocumentType _STV;
        private DocumentType _purchaseOrder;
        private DocumentType _receiptInvoice;
        private DocumentType _cash;
        private DocumentType _credit;
        private DocumentType _igrv;
        private DocumentType _grv;
        private DocumentType _deliveryNote;
        private DocumentType _srm;
        private DocumentType _grnf;
        private DocumentType _errorCorrection;
        private DocumentType _endingBalance;

        public DocumentType STV
        {
            get
            {
                if (_STV == null)
                {
                    _STV = new DocumentType();
                    _STV.Where.DocumentCode.Value = "STV";
                    _STV.LoadByDocumentCode();                    
                }
                return _STV;
            }
        }

        private void LoadByDocumentCode()
        {
            LoadFromRawSql(HCMIS.Repository.Queries.DocumentType.SelectLoadByDocumentCode(Where.DocumentCode.Value));
        }

        private void LoadByDocumentByID()
        {
            LoadFromRawSql(HCMIS.Repository.Queries.DocumentType.SelectLoadByDocumentID(Where.DocumentTypeID.Value));
        }


        public static DocumentType GetDocumentType(string documentTypeCode)
        {
            var documentType = new DocumentType();
            documentType.Where.DocumentCode.Value = documentTypeCode;
            documentType.LoadByDocumentCode();
            return documentType;
        }

        public static DocumentType GetDocumentType(int documentTypeID)
        {
            var documentType = new DocumentType();
            documentType.Where.DocumentTypeID.Value = documentTypeID;
            documentType.LoadByDocumentByID();
            return documentType;
        }

        public static DataTable GetDocumentTypesByPOType(int poTypeID)
        {
            var documentType = new DocumentType();
            var query = HCMIS.Repository.Queries.DocumentType.SelectGetDocumentTypesByPOType(poTypeID);
            documentType.LoadFromRawSql(query);
            return documentType.DataTable;
        }

        public DocumentType PurchaseOrder
        {
            get
            {
                if (_purchaseOrder == null)
                {
                    _purchaseOrder = new DocumentType();
                    _purchaseOrder.Where.DocumentCode.Value = "PO";
                    _purchaseOrder.LoadByDocumentCode();
                    
                } 
                return _purchaseOrder;
            }
   
        }

        public DocumentType ReceiptInvoice
        {
            get
            {
                if (_receiptInvoice == null)
                {
                    _receiptInvoice = new DocumentType();
                    _receiptInvoice.Where.DocumentCode.Value = "RINV";
                    _receiptInvoice.LoadByDocumentCode();

                } 
                return _receiptInvoice;
            }
         
        }

        public DocumentType Cash
        {
            get
            {
                if (_purchaseOrder == null)
                {
                    _cash = new DocumentType();
                    _cash.Where.DocumentCode.Value = "CASH";
                    _cash.LoadByDocumentCode();

                } return _cash;
            }
           
        }

        public DocumentType Credit
        {
            get
            {
                if (_credit == null)
                {
                    _credit = new DocumentType();
                    _credit.Where.DocumentCode.Value = "CRDT";
                    _credit.LoadByDocumentCode();

                } return _credit;
            }
        }

        public DocumentType IGRV
        {
            get
            {
                if (_igrv == null)
                {
                    _igrv = new DocumentType();
                    _igrv.Where.DocumentCode.Value = "IGRV";
                    _igrv.LoadByDocumentCode();

                } return _igrv;
            }
        }

        public DocumentType GRV
        {
            get
            {
                if (_grv == null)
                {
                    _grv = new DocumentType();
                    _grv.Where.DocumentCode.Value = "GRV";
                    _grv.LoadByDocumentCode();

                } return _grv;
            }
        }

        public DocumentType DeliveryNote
        {
            get
            {
                if (_deliveryNote == null)
                {
                    _deliveryNote = new DocumentType();
                    _deliveryNote.Where.DocumentCode.Value = "DLVN";
                    _deliveryNote.LoadByDocumentCode();

                } return _deliveryNote;
            }
        }

        public DocumentType SRM
        {
            get
            {
                if (_srm == null)
                {
                    _srm = new DocumentType();
                    _srm.Where.DocumentCode.Value = "SRM";
                    _srm.LoadByDocumentCode();

                } return _srm;
            }
        }

        public DocumentType GRNF
        {
            get
            {
                if (_grnf == null)
                {
                    _grnf = new DocumentType();
                    _grnf.Where.DocumentCode.Value = "GRNF";
                    _grnf.LoadByDocumentCode();

                } return _grnf;
            }
        }

        public DocumentType ErrorCorrection
        {
            get
            {
                if (_errorCorrection == null)
                {
                    _errorCorrection = new DocumentType();
                    _errorCorrection.Where.DocumentCode.Value = "ERRC";
                    _errorCorrection.LoadByDocumentCode();

                } return _errorCorrection;
            }
        }

        public DocumentType EndingBalance
        {
            get
            {
                if (_endingBalance == null)
                {
                    _endingBalance = new DocumentType();
                    _endingBalance.Where.DocumentCode.Value = "ENDB";
                    _endingBalance.LoadByDocumentCode();

                } return _endingBalance;
            }
        }

        public static int GetNextSequenceNo(int documentTypeId, int accountId, int fiscalYearId)
        {
            int sequenceNo;
            System.Collections.Specialized.ListDictionary Parms = new System.Collections.Specialized.ListDictionary();
            Parms.Add("@DocumentTypeID", documentTypeId);
            Parms.Add("@AccountID", accountId);
            Parms.Add("@FiscalYearID", fiscalYearId);
            Parms.Add("@SequenceNo", 0);

            DocumentType documentType = new DocumentType();
            documentType.LoadFromSql("[sp_GetNextSequence]", Parms, CommandType.StoredProcedure);
            sequenceNo = documentType.Getint("SequenceNo");
            return sequenceNo;

        }

        public int GetNextSequenceNo(int accountId, int fiscalYearId)
        {
            return GetNextSequenceNo(DocumentTypeID, accountId, fiscalYearId);
        }

        public static class CONSTANTS
        {
            public static int STV;
            public static int PO;
            public static int RI;
            public static int CASH;
            public static int CRDT;
            public static int IGRV;
            public static int GRV;
            public static int DLVN;
            public static int SRM;
            public static int GRNF;
            public static int ERRC;
            public static int ENDB;
        
        }
    }
}
