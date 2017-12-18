using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternConsole.PageMaker
{
    /// <summary>
    /// ユーザー名を利用し、リソースファイルに登録されているメールアドレスの検索を行う
    /// </summary>
    class Database
    {
        private Database() { }

        /// <summary>
        /// ユーザ名からメールアドレスを検索する
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static string GetUserMailAddr(string userName)
        {
            return MailData.ResourceManager.GetString(userName);
        }
    }
}
