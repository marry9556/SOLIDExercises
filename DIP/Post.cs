using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Post
    {
        ErrorLogger errorLogger = new ErrorLogger();
        private void CreatePost(Database db, string postMessage)
        {
            try
            {
                db.Add(postMessage);
            }
            catch (Exception ex)
            {

                errorLogger.Log(ex.Message);
            }
        }
    }
}
