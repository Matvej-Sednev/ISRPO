using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace Goroskope
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            timerUpdate.Start();
            nedela.Checked = true;
        }
        public int interval = 0;
        public string age;
        public string tobirth;
        public int vivodddr;
        public int vivodmdr;
        public int ddrnow;
        public int mdrnow;
        public int toddr;
        public int tomdr;
        //seasons
        public int nahvesna = 02;
        public int konvesna = 04;
        public int nahleto = 05;
        public int konleto = 07;
        public int nahosen = 08;
        public int konosen = 10;
        public int nahzima = 11;
        public int konzima = 01;
        //givotnie
        int[] Dog = new int[] { 1910, 1922, 1934, 1946, 1958, 1970, 1982, 1994, 2006, 2018 };
        int[] Dracon = new int[] { 1904, 1916, 1928, 1940, 1952, 1964, 1976, 1988, 2000, 2012 };
        int[] Goat = new int[] { 1907, 1919, 1931, 1943, 1955, 1967, 1979, 1991, 2003, 2015 };
        int[] Horse = new int[] { 1906, 1918, 1930, 1942, 1954, 1966, 1978, 1990, 2002, 2014 };
        int[] Monkey = new int[] { 1908, 1920, 1932, 1944, 1956, 1968, 1980, 1992, 2004, 2016 };
        int[] Ox = new int[] { 1901, 1913, 1925, 1937, 1949, 1961, 1973, 1985, 1997, 2009, 2021 };
        int[] Pig = new int[] { 1911, 1923, 1935, 1947, 1959, 1971, 1983, 1995, 2007, 2019 };
        int[] Rabbit = new int[] { 1903, 1915, 1927, 1939, 1951, 1963, 1975, 1987, 1999, 2011, 2023 };
        int[] Rat = new int[] { 1900, 1912, 1924, 1936, 1948, 1960, 1972, 1984, 1996, 2008, 2020 };
        int[] Rooster = new int[] { 1909, 1921, 1933, 1945, 1957, 1969, 1981, 1993, 2005, 2017 };
        int[] Snake = new int[] { 1905, 1917, 1929, 1941, 1953, 1965, 1977, 1989, 2001, 2013 };
        int[] Tiger = new int[] { 1902, 1914, 1926, 1938, 1950, 1962, 1974, 1986, 1998, 2010, 2022 };

        //elements
        int[] Metall = new int[] { 1900, 1901, 1910, 1911, 1920, 1921, 1930, 1931, 1940, 1941, 1950, 1951, 1960, 1961, 1970, 1971, 1980, 1981, 1990, 1991, 2000, 2001, 2010, 2011, 2020, 2021 };
        int[] Derevo = new int[] { 1904, 1905, 1914, 1915, 1924, 1925, 1934, 1935, 1944, 1945, 1954, 1955, 1964, 1965, 1974, 1975, 1984, 1985, 1994, 1995, 2004, 2005, 2014, 2015 };
        int[] Fire = new int[] { 1906, 1907, 1916, 1917, 1926, 1927, 1936, 1937, 1946, 1947, 1956, 1957, 1966, 1967, 1976, 1977, 1986, 1987, 1996, 1997, 2006, 2007, 2016, 2017 };
        int[] Water = new int[] { 1902, 1903, 1912, 1913, 1922, 1923, 1932, 1933, 1942, 1943, 1952, 1953, 1962, 1963, 1972, 1973, 1982, 1983, 1992, 1993, 2002, 2003, 2012, 2013, 2022, 2023 };
        int[] Earth = new int[] { 1908, 1909, 1918, 1919, 1928, 1929, 1938, 1939, 1948, 1949, 1958, 1959, 1968, 1969, 1978, 1979, 1988, 1989, 1998, 1999, 2008, 2009, 2018, 2019 };

        //zodiaci
        //month
        public int nahmonthvodolei = 01;
        public int konmonthvodolei = 02;
        public int nahmonthoven = 03;
        public int konmonthoven = 04;
        public int nahmonthrak = 06;
        public int konmonthrak = 07;
        public int nahmonthscorpion = 10;
        public int konmonthscorpion = 11;
        public int nahmonthblizneci = 05;
        public int konmonthblizneci = 06;
        public int nahmonthlev = 07;
        public int konmonthlev = 08;
        public int nahmonthvesi = 09;
        public int konmonthvesi = 10;
        public int nahmonthribi = 02;
        public int konmonthribi = 03;
        public int nahmonthstrelec = 11;
        public int konmonthstrelec = 12;
        public int nahmonthkozerog = 12;
        public int konmonthkozerog = 01;
        public int nahmonthtelec = 04;
        public int konmonthtelec = 05;
        public int nahmonthdeva = 08;
        public int konmonthdeva = 09;
        //day
        public int nahdayvodolei = 21;
        public int kondayvodolei = 19;
        public int nahdayoven = 21;
        public int kondayoven = 20;
        public int nahdayrak = 21;
        public int kondayrak = 22;
        public int nahdayscorpion = 23;
        public int kondayscorpion = 22;
        public int nahdayblizneci = 21;
        public int kondayblizneci = 21;
        public int nahdaylev = 23;
        public int kondaylev = 22;
        public int nahdayvesi = 22;
        public int kondayvesi = 22;
        public int nahdayribi = 20;
        public int kondayribi = 20;
        public int nahdaystrelec = 23;
        public int kondaystrelec = 21;
        public int nahdaykozerog = 22;
        public int kondaykozerog = 20;
        public int nahdaytelec = 21;
        public int kondaytelec = 20;
        public int nahdaydeva = 23;
        public int kondaydeva = 21;

        public void dateBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthday = dateBirth.Value.Date;
            DateTime now = DateTime.Now;

            int agey = now.Year - birthday.Year;
            int agem = now.Month - birthday.Month;
            int aged = now.Day - birthday.Day;

            int tobirthm = now.Month - birthday.Month;
            int tobirthd = now.Day - birthday.Day;
            if (now.Month < birthday.Month || now.Month == birthday.Month && now.Day < birthday.Day)
            {
                agey--;
                agem--;
                aged--;
            }
            if (agem < 0)
            {
                agem = 12 + agem;

            }
            if (aged < 0)
            {
                aged = 32 + aged;
            }



            vivodddr = birthday.Day;
            vivodmdr = birthday.Month;
            ddrnow = now.Day;
            mdrnow = now.Month;
            tomdr = tobirthm;
            toddr = tobirthd;
            if (vivodddr >= ddrnow && vivodmdr >= mdrnow)
            {
                tomdr = tomdr * (-1);
                toddr = toddr * (-1);
            }

            tobirth = $"{tomdr} month(s) {toddr} day(s) ";
            age = $"{agey} year(s) {agem} month(s) {aged} day(s) ";
            textBoxCharacteristic.Clear();


        }

        public void buttonAnalysis_Click(object sender, EventArgs e)
        {
            textBoxCharacteristic.Text = "Ваш возраст:";
            textBoxCharacteristic.Text += "\r\n" + age;
            if (vivodddr < ddrnow && vivodmdr < mdrnow)
            {


                textBoxCharacteristic.Text += "\r\n" + "День рождение было ";
                textBoxCharacteristic.Text += "\r\n" + tobirth + "назад";
                textBoxCharacteristic.Text += "\r\n" + "";
            }
            else
            {



                textBoxCharacteristic.Text += "\r\n" + "До дня рождения осталось:";
                textBoxCharacteristic.Text += "\r\n" + tobirth;
                textBoxCharacteristic.Text += "\r\n" + "";
            }





            //zodiac
            int zodiacmonth = dateBirth.Value.Month;
            int zodiacday = dateBirth.Value.Day;
            if (zodiacday >= nahdayoven && zodiacmonth == nahmonthoven || zodiacday <= kondayoven && zodiacmonth == konmonthoven)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\aries.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Овен. Представители этого знака целеустремленные и обычно знают, чего хотят.  Однако из-за чрезмерного напора им не всегда получается все получить. Овны — страстные, темпераментные, честные и мужественные люди, благодаря чему все, что их окружает, наполнено драйвом и энергией.";
            }

            if (zodiacday >= nahdaytelec && zodiacmonth == nahmonthtelec || zodiacday <= kondaytelec && zodiacmonth == konmonthtelec)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\taurus.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Телец одновременно скромен и романтичен благодаря Венере — планете любви. Тельцы, как правило, надежные, сильные, терпеливые и ответственные люди. Но иногда они могут проявлять упрямство, равнодушие и ревность. Телец — прекрасный знак, который умеет заранее планировать и ставить задачи для достижения общей цели, а также грамотно распоряжаться деньгами и просто относиться к жизни.";
            }

            if (zodiacday >= nahdayblizneci && zodiacmonth == nahmonthblizneci || zodiacday <= kondayblizneci && zodiacmonth == konmonthblizneci)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\gemini.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "ВБлизнецы сообразительный и умный знак, для которого важно постоянно чему-то учиться и с кем-то общаться. Они умеют сопереживать и сочувствовать. Однако из-за переизбытка энергии становятся беспокойными и неспособны принимать решения и фокусироваться на чем-то одном долгое время.";
            }

            if (zodiacday >= nahdayrak && zodiacmonth == nahmonthrak || zodiacday <= kondayrak && zodiacmonth == konmonthrak)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\cancer.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Раки как известно, олицетворяют материнство и хранителей домашнего очага.Из лучших качеств в Раках можно выделить творческий подход и чуткость, из худших — привычку манипулировать кем-то и быть пессимистами. Хотя представители этого водяного знака домоседы по природе, но никогда не откажутся от увлекательного путешествия.";
            }

            if (zodiacday >= nahdaylev && zodiacmonth == nahmonthlev || zodiacday <= kondaylev && zodiacmonth == konmonthlev)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\leo.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Львы действительно ведут себя в жизни как короли или королевы <<джунглей>>. Этот знак может быть настоящим лидером — творческим и активным, но ему также присуще временами драматизировать, стесняться, проявлять эгоизм и высокомерие. Эксперт по астрологии рекомендует <<найти баланс>> между этими качествами. Все-таки Львы как никто знают, как <<следовать зову сердца>> и не бояться этого.";
            }

            if (zodiacday >= nahdaydeva && zodiacmonth == nahmonthdeva || zodiacday <= kondaydeva && zodiacmonth == konmonthdeva)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\virgo.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Девы известны своей внимательностью к деталям, логичностью и прагматичностью. Этот знак глубоко предан, добр и великодушен к людям. Однако у Дев есть и отрицательные стороны. Представители этого знака любят критиковать себя и других, а также переживать по пустякам и работать больше, чем положено, забывая об отдыхе и развлечениях.";
            }

            if (zodiacday >= nahdayvesi && zodiacmonth == nahmonthvesi || zodiacday <= kondayvesi && zodiacmonth == konmonthvesi)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\libra.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Весы ориентированы на партнерство. Этот знак уважает личное пространство другого человека и умеет слушать. Знает, что и когда сказать, а когда лучше промолчать. Представители этого знака, как правило, очень добрые, дипломатичные, заботливые и щедрые люди, которые стараются поступать только правильно. Но и они же склонны хранить обиду и не брать на себя ответственность, даже если стали участником какого-то конфликта.";
            }

            if (zodiacday >= nahdayscorpion && zodiacmonth == nahmonthscorpion || zodiacday <= kondayscorpion && zodiacmonth == konmonthscorpion)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\scorpio.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Скорпион яркий и проницательный знак зодиака. Однако, несмотря на эту энергию, они часто производят впечатление замкнутых людей. Спокойствие и непринужденность — вот та атмосфера, которую любят создавать вокруг себя представители этого знака, независимо от того, что чувствуют на самом деле.";
            }

            if (zodiacday >= nahdaystrelec && zodiacmonth == nahmonthstrelec || zodiacday <= kondaystrelec && zodiacmonth == konmonthstrelec)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\sagittarius.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Стрельцы не любят подчиняться, из-за чего они часто находятся на своей волне. В астрологии представители этого знака считаются веселыми и харизматичными авантюристами со своей философией, суть которой состоит в том, чтобы сделать эту жизнь немного лучше.Но даже несмотря на это, со временем к Стрельцам приходят более глубокие знания и мудрость.";
            }

            if (zodiacday >= nahdaykozerog && zodiacmonth == nahmonthkozerog || zodiacday <= kondaykozerog && zodiacmonth == konmonthkozerog)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\capricorn.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Козерога нельзя назвать веселым и легким знаком зодиака. Но это и к лучшему, потому что у него есть выигрышные стороны, которых нет у других. Представители этого знака сильные и стойкие люди, которые любят добиваться целей.Известные своей ответственностью, дисциплиной и чувством такта, Козероги, как правило, делают успешную карьеру. Но в семье и любви с ними могут быть проблемы из-за чрезмерной требовательности Козерогов — они возлагают слишком большие надежды на окружающих.";
            }

            if (zodiacday >= nahdayvodolei && zodiacmonth == nahmonthvodolei || zodiacday <= kondayvodolei && zodiacmonth == konmonthvodolei)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\aquarius.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Водолеи знают не только, как поймать ритм жизни, но и как создать его. Представители этого знака — бунтари, которые как никто умеют находить решения старых проблем и проникать в суть того, что действительно важно, не прислушиваясь к мнению других. Однако временами они могут казаться бессердечными и непреклонными. Им тяжело выражать чувства.";
            }

            if (zodiacday >= nahdayribi && zodiacmonth == nahmonthribi || zodiacday <= kondayribi && zodiacmonth == konmonthribi)
            {
                pictureBoxImageZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Zodiac\pisces.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по зз:";
                textBoxCharacteristic.Text += "\r\n" + "Рыбы. На первый взгляд этот знак может показаться излишне романтичным и мечтательным, однако Рыбы могут также быстро остыть, если их обидеть или проявилось неуважение. Представленные двумя рыбами, плывущими в противоположных направлениях, кажется, что этот знак всегда должен делать выбор или выбирать между тем или иным путем — иногда реальностью и миром их фантазий. Рыбы — мудрые, щедрые, у них развита интуиция, но из-за чрезмерной доверчивости, часто бывают напуганы и чем-то обеспокоены.";
            }
            textBoxCharacteristic.Text += "\r\n" + "";
            //givotnoe
            int givotnoe = dateBirth.Value.Year;
            if (Dog.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-dog.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Собаки дружелюбны, щедры и справедливы в отношении окружающих. И хотя они очень лояльны к недостаткам другим, внутри у них будто установлен мощный моральный компас, который они просто не в состоянии игнорировать. Собака — надежная «жилетка» для слез в моменты печали и отличный собеседник для разговоров по душам.";
            }
            if (Dracon.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-dragon.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Люди-Драконы столь же загадочны, как и их мифический символ. Но это не значит, что они закрыты от окружающих и непостижимы. Наоборот, Драконы очень креативные и гибкие, легко адаптируются под различные «условия игры» — их вкусы могут резко измениться, но они по-прежнему остаются теми же страстными и мотивированными героями.";
            }
            if (Goat.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-goat.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Овца. Люди, рожденные под этим знаком, известны своим безупречным вкусом, индивидуальным стилем и изысканностью в манерах. Исходя из символики можно предположить, что Козы очень упрямые. Но это на самом деле совсем не так. Куда выше они ценят собственное душевное спокойствие и ради этой цели могут легко уступить в позиции или мнении другому.";
            }
            if (Horse.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-horse.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Лошадь, как и положено символу, очаровательная и искренняя в своих проявлениях и реакциях, что делает ее довольно популярной и востребованной — все хотят с ней дружить и ее любить. Впрочем, сами представители знака против этого не возражают. Тем не менее, время от времени любой Лошади нужно побыть наедине, чтобы прийти в состояние гармонии. Нет, они не одиноки, но определенно жаждут независимости.";
            }
            if (Monkey.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-monkey.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Обезьяна. Чересчур активные и неутомимые. Представители этого знака любят держать других в движении и напряжении. Важная черта всех Обезьян — невероятная жажда жизни, знаний, приключений и успеха. Да-да, им не чужды королевские амбиции!";
            }
            if (Ox.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-ox.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Бык. Как и их «тезки» — Тельцы — в западном гороскопе, Быки — главные трудоголики из всей дюжины. Это очень ответственные и надежные люди. Единственная раздражающая черта — они чертовски упрямые и упертые. Впрочем, именно это качество часто помогает им достигать головокружительных карьерных и даже личных высот. Они ни за что не сойдут со своего пути на Олимп. А еще Быки невероятно терпеливы и внимательны к другим людям.";
            }
            if (Pig.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-pig.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Благородная Свинья, возможно, не самый скромный знак, но ее щедрое, даже филантропическое и альтруистическое отношение к другим делает ее одним из самых уважаемых представителей китайской дюжины. Такие люди обладают приятным внутренним драйвом и ценят честность. Но самое приятное — они не скупятся на проявление чувств, если по-настоящему влюблены.";
            }
            if (Rabbit.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-rabbit.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Кролики такие же сообразительные, как и их прототипы в природе, но не ожидайте, что они будут использовать свой пластичный ум для решения бытовых задач. Они мыслят по-крупному. Представители этого знака больше всего ценят мир и спокойствие, поэтому сильнее всего боятся разного рода конфликтов. В соответствии с этой теорией, Кролики очень ласковые и внимательные друзья, партнеры и коллеги. В их доме каждый человек чувствует себя желанным гостем.";
            }
            if (Rat.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-rat.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз :";
                textBoxCharacteristic.Text += "\r\n" + "Крыса. Перед вами прирожденные лидеры. Часто их излишнюю самоуверенность принимают за высокомерие, хотя в действительности это совсем не так. По своей сути Крысы — люди щедрые и невероятно умные, а вовсе не изворотливые. Просто их отличает то, что они не боятся уверенно заявлять о своих амбициях, в то время как другие из страха, хитрости или скромности держат их при себе.";
            }
            if (Rooster.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-rooster.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Петух. Пожалуй, одни из самых практичных, независимых и самостоятельных знаков восточного калейдоскопа. Они собранны, сдержанны и продвигаются по заранее намеченному маршруту точно к цели. Петухи эффективны в работе и заслуживают доверия в дружбе. А еще просто поразительно — насколько они пунктуальны!";
            }
            if (Snake.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-snake.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Змея — один из самых магнетических и экстравагантных знаков. А какой сумасшедшей энергетикой обладают представители этих годов! Их проницательный характер, мудрость и общая утонченность, безусловно, делают их сильными личностями. Змеи — не одиночки, они могут стать фантастическими и верными союзниками благодаря способности объективно смотреть на любые проблемы.";
            }
            if (Tiger.Contains(givotnoe))
            {
                pictureBoxImageChineseZodiac.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\ChineseZodiac\year-of-tiger.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайскому зз:";
                textBoxCharacteristic.Text += "\r\n" + "Тигр. Представители этого знака известны своей храбростью. А еще, подобно астрологическим Львам, они любят быть в центре внимания и определенно выделяются из толпы/коллектива. Тигры невероятно харизматичны и часто оказываются на руководящих должностях, даже если никак специально не педалировали и не продвигали эту тему.";
            }
            textBoxCharacteristic.Text += "\r\n" + "";
            //elements
            int element = dateBirth.Value.Year;
            if (Metall.Contains(element))
            {
                pictureBoxImageElement.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Element\металл.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайской стихии:";
                textBoxCharacteristic.Text += "\r\n" + "Наделяя своих подопечных внутренней силой, Железо (Металл) тем не менее не обеспечивает им возможности противостоять ударам судьбы. На долю «железных» людей выпадает немало болезней, кроме того, почти все они в разные периоды жизни испытывают тягу к самоубийству. Умея управлять другими, люди металла не в состоянии жить в ладу с собой, а худшие из них и вовсе способны радоваться лишь тому, что смогли возвыситься над другими.";
            }

            if (Derevo.Contains(element))
            {
                pictureBoxImageElement.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Element\дерево.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайской стихии:";
                textBoxCharacteristic.Text += "\r\n" + "Людям Дерева свойственны доброта, отзывчивость, непосредственность реакций и поступков. Они мечтают посвятить свою жизнь путешествиям или исследованиям, и, если не имеют такой возможности, дают волю своей безграничной фантазии, превращаясь в изобретателей, блестящих рассказчиков или писателей. Они идеалисты, всерьез обеспокоены вопросами этики, легко разочаровываются в людях.";
            }

            if (Fire.Contains(element))
            {
                pictureBoxImageElement.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Element\огонь.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайской стихии:";
                textBoxCharacteristic.Text += "\r\n" + "Люди Огня отличаются особенной страстностью, они всегда находятся на пике эмоций и попросту не знают покоя. Подвижные, энергичные, жаждущие приключений, они легко завоевывают сердца, да и сами испытывают по отношению к окружающим очень сильные чувства.";
            }

            if (Water.Contains(element))
            {
                pictureBoxImageElement.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Element\вода.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайской стихии:";
                textBoxCharacteristic.Text += "\r\n" + "Вода дает миру дипломатов, которые сочетают гибкость с целеустремленностью, а вежливость — с настойчивостью; такие люди ставят перед собой цель, до которой крайне сложно добраться прямым путем, но все же добиваются успеха.";
            }
            if (Earth.Contains(element))
            {
                pictureBoxImageElement.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Element\земля.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по китайской стихии:";
                textBoxCharacteristic.Text += "\r\n" + "Люди Земли ответственно, обстоятельно и вдумчиво подходят к любому вопросу. Они склонны рассуждать, а не делать, и, надо признать, преуспевают в умственном труде. Терпение, осторожность и рассудительность позволяют людям Земли не совершать ошибок, но лишают их возможности импровизировать, совершать неожиданные поступки, совершать открытия.";
            }
            textBoxCharacteristic.Text += "\r\n" + "";
            //seasons
            int seasons = dateBirth.Value.Month;
            if (seasons >= nahvesna && seasons <= konvesna)
            {
                pictureBoxImageSeason.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Season\spring.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по сезону рождения:";
                textBoxCharacteristic.Text += "\r\n" + "Рожденные весной: Люди, появившиеся на свет весной, буквально впитывают в себя пробуждение природы. Они стремительно развиваются, обладают мгновенной реакцией и неиссякаемым источником энергии. Часто эгоистичны и требуют внимания и уважения к своей персоне. Однако при явном себялюбии обладают и альтруистическими наклонностями. В порыве жалости способны отдать последнее, не задумываясь. Легко находят контакт с людьми, однако часто страдают из-за резких высказываний. При правильном развитии с детства избегают большинства болезней, обладают хорошим здоровьем. Их путь — движение. Вечный поиск и нежелание останавливаться на достигнутом позволяет развить лидерские способности. Это прекрасные друзья и семьянины, но круг их общения ограничен теми, кто понял и признал особенности их характера.";

            }

            if (seasons >= nahleto && seasons <= konleto)
            {
                pictureBoxImageSeason.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Season\summer.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по сезону рождения:";
                textBoxCharacteristic.Text += "\r\n" + "Рожденные летом: Тех, кто родился летом, можно назвать поцелованными Судьбой. Они энергичны, но способны дозировать свои порывы, обладают хорошей деловой хваткой и полностью уверены в своих силах. Обычно рожденным летом присуща некоторая медлительность и выжидание, но чаще всего это осознанный выбор стратегии. Когда наступает благоприятный момент, летние люди способны к быстрым и правильным решениям, руководствуются доводами разума и редко идут на поводу эмоций. Им присущ здоровый эгоизм, связанный с личными достижениями и заслугами. Это люди с открытым сердцем, редко способные опуститься до предательства и лжи. В отношениях стремятся быть главными, но прислушиваются к мнению своей половинки. Легкий и веселый нрав обеспечивает им хорошую репутацию. Они постоянно окружены друзьями и часто помогают им в трудную минуту советами и активными действиями, ничего не требуя взамен.";
            }

            if (seasons >= nahosen && seasons <= konosen)
            {
                pictureBoxImageSeason.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Season\autumn.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по сезону рождения:";
                textBoxCharacteristic.Text += "\r\n" + "Рожденные осенью: Осенние люди — вдумчивые и ответственные, несколько рассеянны и часто склонны к пессимистичным мыслям. Из них нередко вырастают прекрасные предприниматели и бизнесмены, четко осознающие значимость своего дела и способные на рискованные поступки в достижении благополучия. Но чаще всего эти люди выбирают художественную направленность и реализуют себя в одной из сфер искусства. Характерные особенности осенних людей позволяют им составлять долгосрочные планы, в который по полочкам разложен каждый шаг и предпринимаемое действие. Они ограничивают свой круг общения и часто замыкаются от окружающего мира, предпочитая размышлять в одиночестве. Способны докопаться до смысла в интересующем деле, а также досконально изучить вопрос, непосредственно касающийся их жизни. В жизни ценят гармонию и стабильность, поэтому не торопятся с выбором спутника жизни.";
            }

            if (seasons >= nahzima || seasons == konzima)
            {
                pictureBoxImageSeason.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\IMAGE\Season\winter.png");
                textBoxCharacteristic.Text += "\r\n" + "Характеристика по сезону рождения:";
                textBoxCharacteristic.Text += "\r\n" + "Рожденные зимой: Холодное время года способствует развитию сильной личности, не зависящей от чужого мнения, поэтому зимние месяцы богаты на рождение детей с лидерскими способностями. Обычно эти люди выбирают свой путь и руководствуются внутренними ориентирами на пути к благополучию. Природа не балует их подарками при рождении, а наоборот, заставляет воспитывать в себе силу воли и бороться за пальму первенства. Часто зимним людям присуща некоторая холодность и отстраненность. Они сдержанны в эмоциях и редко выходят из себя по пустякам, однако свою точку зрения отстаивают с небывалым пылом. Им присуще одиночество из-за недопонимания окружающих, и часто зимние люди замыкаются в себе. Рожденные в холодное время года часто обладают слабым иммунитетом, склонны к травмам и хроническим заболеваниям дыхательной системы. Сдержанность часто мешает им во взаимоотношениях, и поэтому долгое время эти люди находятся без пары. Но терпение и умение ждать обычно окупается счастливым нахождением второй половинки и крепкими семейными отношениями.";
            }
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("G");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCharacteristic_TextChanged(object sender, EventArgs e)
        {

        }
        private void StroenieGrafa()
        {
            //chorte.Series[0].Points.Clear();
            //chorte.Series[1].Points.Clear();
            //chorte.Series[2].Points.Clear();
            //chorte.Series[3].Points.Clear();
            chorte.BackColor = System.Drawing.Color.Azure;

            ChartArea chartArea = new ChartArea();
            chorte.ChartAreas.Add(chartArea);

            Series seriesSin = new Series();
            seriesSin.ChartType = SeriesChartType.Spline;
            chorte.Series.Add(seriesSin);
            Series seriesCos = new Series();
            seriesCos.ChartType = SeriesChartType.Spline;
            chorte.Series.Add(seriesCos);
            Series seriesCosSin = new Series();
            seriesCosSin.ChartType = SeriesChartType.Spline;
            chorte.Series.Add(seriesCosSin);
            Series series = new Series();
            series.ChartType = SeriesChartType.Spline;
            chorte.Series.Add(series);
        }
        public static DateTime week, mounse, birthday,now;
        public static double x;
        private void RadioBaton() 
        {
            int a = 0;
            do
            {
                if (fiz.Checked == true)
                {
                    x = Math.Sin(Math.PI * 2 * x / 23);
                    a++;
                }
                else if (emoc.Checked == true)
                {
                    x = Math.Sin(Math.PI * 2 * x / 28);
                    a++;
                }
                else if (smart.Checked == true)
                {
                    x = Math.Sin(Math.PI * 2 * x / 33);
                    a++;
                }
                StroenieGrafa();
            } while (a == 3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            birthday = dateBirth2.Value.Date;
            now = DateTime.Now;



            if (nedela.Checked == true)
            {
                week = now.AddDays(7);
                x = 7;

                RadioBaton();
            }
            else if (mesach.Checked == true)
            {


                mounse = now.AddMonths(1);
                int X = Convert.ToInt32(mounse - birthday);
                RadioBaton();

            }
            else if (period.Checked == true)
            {
                RadioBaton();
            }
            else MessageBox.Show("Неизвестная Ошибка");
        }
    }
}


