using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBusiness;

namespace CHQLDoNoiThat
{
    public class Utils
    {
        public static AccountObject getUserInfo(string uid, ref string error)
        {
            DBL_Account dbl = new DBL_Account();

            var ds = dbl.employee_get_account(uid, ref error);
            if (ds != null && ds.Tables[0].Rows.Count == 1)
            {
                var tmp = ds.Tables[0].Rows[0].ItemArray;
                return new AccountObject(
                            (string)tmp[0],
                            (string)tmp[1],
                            (DateTime)tmp[2],
                            (string)tmp[3],
                            (string)tmp[4],
                            (string)tmp[5],
                            (string)tmp[6],
                            (string)tmp[7],
                            tmp[9] != DBNull.Value ? (byte[])tmp[9] : Array.Empty<byte>(),
                            (string)tmp[10]
                            );
            }
            else
            {
                return null;
            }
        }

        public static string getTypeAccName(string id, ref string error)
        {
            DBL_TypeAccount dbl = new DBL_TypeAccount();
            var ds = dbl.get_typeaccounts(ref error);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                var tmp = ds.Tables[0].Rows;
                for (int i = 0; i < tmp.Count; i++)
                {
                    if ((string)tmp[i].ItemArray[0] == id)
                        return (string)tmp[i].ItemArray[1];
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public static Bitmap ByteToImage(byte[] blob, Size new_size)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(new Bitmap(mStream, false), new_size);
            mStream.Dispose();
            return bm;
        }
    }
}
