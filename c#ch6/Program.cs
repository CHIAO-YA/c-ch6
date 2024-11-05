using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace c_ch6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //6-1寫一個function 可以把一般對話框的文字轉成HTML。
            //> 轉成 & gt; < 轉成 & lt; \r\n 轉成<br> | 轉成 & brvbar; 空白 轉成 &nbsp;
            //    Console.WriteLine("請輸入文字:");
            //    string input = Console.ReadLine();
            //    string htmlOutput = ConvertToHtml(input); //文字轉為 HTML
            //    Console.WriteLine("轉為html");
            //    Console.WriteLine(htmlOutput);
            //}
            //public static string ConvertToHtml(string input)
            //{
            //    if (string.IsNullOrEmpty(input))
            //    { return ""; 
            //    }

            // string output = input
            //        .Replace(">", "&gt;")
            //        .Replace("<", "&lt")
            //        .Replace("\r\n", "<br>")
            //        .Replace("|", "&brvbar;")
            //        .Replace(" ", "&nbsp;");
            //    return output;


            //6-2寫一個function，回傳輸入的值是否數字
            //      Console.WriteLine("請輸入一個值:");
            //      string input = Console.ReadLine();//讀取

            //      Program program = new Program();// 創建 Program，呼叫 number
            //      bool isNumber = program.IsNumber(input); // 呼叫 IsNumber 方法
            //      if (isNumber)
            //      {
            //          Console.WriteLine("是數字");
            //      }
            //      else
            //      {
            //          Console.WriteLine("不是數字");
            //      }
            //      Console.ReadKey();
            //  }
            //  public bool IsNumber(string input)
            ////公開   是否  方法名稱(字串  檢查)
            //  {
            //      double result;//宣告變數  儲存轉換的數字值
            //                    //轉換值  靜態方法文字轉數字(轉換  變數在方法內被賦值)
            //                    //TryParse 方法會返回 true 如果轉換成功，否則返回 false。
            //                    //如果轉換成功，result 會包含轉換後的數字；如果失敗，result 將保持其初始值。
            //      return double.TryParse(input, out result);

            //6-3寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
            //e-mail---->regex驗證
            //    Console.WriteLine("請輸入一個電子郵件地址:");
            //    string input = Console.ReadLine();

            //    bool isemail = Isemail(input);
            //    if (isemail)
            //    {
            //        Console.WriteLine("電子郵件有效");
            //    }
            //    else
            //    {
            //        Console.WriteLine("電子信箱無效");
            //    }
            //}
            ////判斷是否符合
            //public static bool Isemail(string email)
            //{
            //    if (string.IsNullOrEmpty(email))
            //    {
            //        return false;
            //    }
            //    //@逐字字符串 不需要轉義
            //    //^開始 @\s防止輸入空白字符或@ + @ +\.分隔像是.com
            //    //$確保.com.net.org結尾
            //    string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            //    Regex regex = new Regex(pattern);
            //    return regex.IsMatch(email);
            //}

            //6-4寫一個function，回傳輸入的值是否符合手機格式
            //    Console.WriteLine("輸入電話");
            //    string input = Console.ReadLine();
            //    bool isnumber = isturenumber(input);
            //    if (isnumber)
            //    {
            //        Console.WriteLine("有效");
            //    }
            //    else
            //    {
            //        Console.WriteLine("無效");
            //    }
            //}
            //public static bool isturenumber(string input)
            //    {
            //     //\d數字
            //     string pattern = @"^09\d{8}$";
            //     Regex regex = new Regex(pattern);
            //     return regex.IsMatch(input);

            //6-5寫一個function，回傳輸入的值是否符合身分證字號格式
            //    Console.WriteLine("輸入身分證");
            //    string input = Console.ReadLine();
            //    bool isID = istureID(input);
            //    if (isID)
            //    {
            //        Console.WriteLine("有效");
            //    }
            //    else
            //    {
            //        Console.WriteLine("無效");
            //    }
            //}
            //public static bool istureID(string input)
            //{
            //    string pattern = @"^[A-Z][1-2]\d{8}$";
            //    Regex regex = new Regex(pattern);
            //    return regex.IsMatch(input);

            //}

            //6-6寫一個function，若輸入的文字大於N個，則超過的字不要，變成點點點
            //    Console.WriteLine("請輸入一段文字");
            //    string input = Console.ReadLine();
            //    Console.WriteLine("請輸入對大字數顯示範圍");
            //    int max = int.Parse(Console.ReadLine());

            //    // 呼叫 maxtext 函數並將結果存入 result
            //    string result = maxtext(input, max);
            //    Console.WriteLine("結果");
            //    Console.WriteLine(result); //直接顯示
            //    }
            //public static string maxtext(string text, int max)
            //{
            //    if (text.Length > max)
            //    {
            //        return text.Substring(0, max) + "...";
            //    }//Substring從text位置0開始截取max個字數
            //     //return 語句會將這個新字串回傳給主程式
            //    else
            //    {
            //        return text;
            //    }

            //6-7寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
            //---->格式yyyy.MM.dd用 DateTime.TryParse()
            //Console.WriteLine("輸入一個日期 ex:2024.10.21");
            //string input = Console.ReadLine();

            //DateTime inputdate;
            //if (DateTime.TryParse(input.Replace('.', '/'), out inputdate))
            //{
            //    string result = ConvertToDateTime(inputdate);
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("輸入的日期格式不正確");
            //}
            // string ConvertToDateTime(DateTime date)
            //{
            //    int year = date.Year-1911;
            //    return$"{year}.{date.Month:D2}.{date.Day:D2}";
            //}

            //6-8寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式
            //    Console.WriteLine("輸入一個日期 ex:2024.10.21");
            //    string input = Console.ReadLine();
            //    DateTime inputdate;
            //    if (DateTime.TryParse(input.Replace('.', '/'), out inputdate))
            //    {
            //        string result = Weekday(inputdate);
            //        Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("格式不正確");
            //    }
            //}
            //    static string Weekday(DateTime inputdate)
            //    {
            //        int year = inputdate.Year-1911;
            //        string[] week = { "日", "一", "二", "三", "四", "五", "六" };
            //        string weekday = week[(int)inputdate.DayOfWeek];
            //        return$"{year}年{inputdate.Month}月{inputdate.Day}日 星期{weekday}";
            //    }

            //6-9寫一個function，回傳輸入的年是否閏年
            //--->閏年要先被4整除再100或400 兩者皆可-->閏年leap
            //-->如果是民國就+1911
            //    Console.WriteLine("請輸入西元年");
            //    int year = int.Parse(Console.ReadLine());
            //    bool leap = isleap(year);
            //    Console.WriteLine($"{year}是閏年嗎?{leap}");
            //    }
            //public static bool isleap(int year)
            //{
            //    if (year % 4 == 0)
            //    {
            //        if (year % 100 == 0)
            //        {
            //            return year % 400 == 0;
            //        }
            //        return true;
            //    } return false;
            //}

            //6-10寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：
            //用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），
            //再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)
            //    Console.Write("輸入手機號碼");
            //    String phone = Console.ReadLine();
            //    double lucky = luckyphone(phone);
            //    Console.WriteLine("計算結果:" + (int)lucky);
            //    Console.WriteLine("1、宇宙起源,天地開泰太極首領數。(大吉)\r\n2、混飩未定,分離破敗數。(大凶)\r\n3、進取如意的增進繁榮數。(大吉)\r\n4、破敗凶變的萬事休止數(大凶)\r\n5、福祿長壽的福德集門數。(大吉)\r\n6、安穩餘慶吉人天相數。(大吉)\r\n7、剛毅果斷勇往直前的進取數。(吉)\r\n8、意志剛健的勤勉發展數。(吉)\r\n9、興盡凶始,窮乏困苦數。(凶)\r\n10、萬事終局充滿損耗數。(凶)\r\n11、穩健吉右富貴榮達數。(大吉)\r\n12、意志薄弱的家庭寂寞數。(凶)\r\n13、智略超群的博學多才數。(大吉)\r\n14、淪落天涯失意煩悶數。(凶)\r\n15、福壽雙全的立身興家數。(大吉)\r\n16、貴人相助興家興業的大吉數。(大吉)\r\n17、突破萬難的剛柔兼備數。(大吉)\r\n18、有志竟成的內名有運數。(大吉)\r\n19、反應機敏,先聲奪人數。(中吉)\r\n20、實而不華,深藏不露數。(中吉)\r\n21、明月光照,獨立權威數。(大吉)\r\n22、秋草逢霜的兩士相爭數。(半吉半凶)\r\n23、旭日東升的質實剛堅數。(大吉)\r\n24、家門餘慶的金錢豐盈數。(大吉)\r\n25、英俊剛毅資性聰敏數。(大吉)\r\n26、變怪奇異的豪俠數。(半吉半凶)\r\n27、足智多謀,先苦后甜數。(半凶半吉)\r\n28、家親緣薄,離群獨處無定數。(凶)\r\n29、智謀兼備,慾望難足數。(半吉半凶)\r\n30、一成一敗,絕處逢生數。(半凶半吉)\r\n31、智勇得志,心想事成數。(大吉)\r\n32、權貴顯達的意外惠澤數。(大吉)\r\n33、家門隆昌的才德開展數。(大吉)\r\n34、破家亡身財命危險數。(凶)\r\n35、溫和平靜的優雅發展數。(大吉)\r\n36、風浪不息的俠義薄運數。(半凶半吉)\r\n37、權威顯達、吉人天相數。(大吉)\r\n38、磨鐵成針刻意經營數。(半凶半吉)\r\n39、富貴榮華的變化無窮數。(半凶半吉)\r\n40 、謹慎保安的豪膽邁進數。(半凶半吉)\r\n41、德高望重的事事如意數。(大吉)\r\n42、寒蟬在柳,十藝不成數。(凶)\r\n43、邪途散財,外祥內苦數。(半凶半吉)\r\n44、鬚眉難展力量有限數。(凶)\r\n45、順風揚帆、新生泰和的萬事如意數。\r\n(大吉) 46、羅網系身離祖成家數。(半凶半吉)\r\n47、點鐵成金,開花結果的權威進取數。(大吉)\r\n48、青松方鶴、德智兼備的出身清貴數。(大吉) 49、吉凶難分的不斷辛勞數。(凶)\r\n50、小舟入海,吉凶參半,須防傾覆數。(半凶半吉) 51、盛衰交加的竭力經營數。(半凶半吉)\r\n52、先見之明,理想實現數。(吉)\r\n53、憂愁困苦,先苦后甜數。(半凶半吉)\r\n54、多難悲運的難望成功數。(凶)\r\n55、外祥內苦的和順不實數。(凶)\r\n56、浪里行舟、歷盡艱辛,四周障害數。(凶)\r\n57、寒雪青松的最大榮運數。(吉)\r\n58、晚行遇月、先苦後甘,寬宏揚名數。(半凶半吉) 59、寒嬋悲風、時運不濟數。(凶)\r\n60、爭名奪利,黑暗無光數。(凶)\r\n61、名利雙收的修鍊積德數。(吉）\r\n62、基礎虛弱的艱難困苦數。(凶)\r\n63、富貴榮華的身心安泰數。(大吉)\r\n64、骨肉分離,孤兒悲愁數。 (凶)\r\n65、富貴長壽的光明正大數。 （大吉）\r\n66、內外不和的多欲失福數。 (吉)\r\n67、財路亨通的志氣堅強數。 （吉）\r\n68、興家立業的寬容好運數。 (吉)\r\n69、坐立不安的外世多難數。(凶)\r\n70、家運衰退的晚景淒涼數。(凶) 、\r\n71、毫無實質的耗神而勞數。(半凶半吉)\r\n72、先甜后苦的萬難艱辛數。(凶)\r\n73、志高力微的努力奮鬥數。(半凶半吉)\r\n74、沉淪逆境的秋葉落寞數。(凶)\r\n75、守者可安,發跡甚遲數。(半凶半吉)\r\n76、傾覆離散,雖勞無功數。(凶)\r\n77、家庭有悅的半吉半凶數。(半凶半吉)\r\n78、晚境凄涼的功德光榮數。(半凶半吉)\r\n79、挽回乏力的身疲力盡數。(凶)\r\n80、凶星入度的清本縮小數。(凶)\r\n81、萬物回春,還原復始的積極盛大數。(大吉)");
            //}
            //public static double luckyphone(String phone)
            //{
            //    if (phone.Length < 10)
            //    {
            //        Console.WriteLine("手機長度不足");
            //        return 0;
            //    }
            //    string number = phone.Substring(phone.Length - 4);
            //    int lastfournumber = int.Parse(number);
            //    double a = lastfournumber / 80.0;
            //    double b = a - Math.Floor(a);
            //    double result = b * 80;
            //    return result;
              }

           


        }
    }
