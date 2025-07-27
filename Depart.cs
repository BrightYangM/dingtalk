using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public  class Depart
    {
        private string departmentID = "";

        public string ID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }

        private string departmentName = "";

        public string Name
        {
            get { return departmentName; }
            set { departmentName = value; }
        }


    }

  public class User
  {
      private string departmentID = "";

      public string ID
      {
          get { return departmentID; }
          set { departmentID = value; }
      }

      private string departmentName = "";

      public string Name
      {
          get { return departmentName; }
          set { departmentName = value; }
      }


  }

  public class SceneDetect
  {
      private string id = "";

      public string ID
      {
          get { return id; }
          set { id = value; }
      }

      private string car = "";

      public string Car
      {
          get { return car; }
          set { car = value; }
      }

      private string beginDate = "";

      public string BeginDate
      {
          get { return beginDate; }
          set { beginDate = value; }
      }

      private string endDate = "";

      public string EndDate
      {
          get { return endDate; }
          set { endDate = value; }
      }

      private string cusName = "";

      public string CusName
      {
          get { return cusName; }
          set { cusName = value; }
      }

      private string cusAddr = "";

      public string CusAddr
      {
          get { return cusAddr; }
          set { cusAddr = value; }
      }

      private string verifyBy = "";

      public string VerifyBy
      {
          get { return verifyBy; }
          set { verifyBy = value; }
      }

      private string file = "";

      public string File
      {
          get { return file; }
          set { file = value; }
      }

  }
}
