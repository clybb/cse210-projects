 class Topics{
    protected List<string> _quotes = new List<string>();

    protected string _statement;

    public void DisplayAll(){
        Console.WriteLine("\n{1}Topic: {3}{0}{2}\n", GetType(), "\u001b[1m", "\u001b[0m", "\u001b[31m");
        foreach(var quote in _quotes){
            Console.WriteLine(quote);
        }
        Console.WriteLine("{3}Posistion Statement:{2}\n{1}{4}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[1m", "\u001b[31m");
    }
    virtual public void DisplayRandom(){
  
    }
    
}
class Family:Topics{
    
    public Family(){
        _quotes.Add("\"This was evident from the very beginning when the Lord declared “that it was not good that the man should be alone; wherefore [He would] make an \nhelp meet for him.”\"(In partnership with the Lord, Elder Soares October 2022 General Conference)\n");
        _quotes.Add("\"In the Lord’s plan, a “help meet” was a companion who would walk shoulder to shoulder with Adam in full partnership. In fact, Eve was a heavenly \nblessing in Adam’s life. Through her divine nature and spiritual attributes, she inspired Adam to work in partnership with her to achieve \nGod’s plan of happiness for all mankind.\"(In partnership with the Lord, Elder Soares October 2022 General Conference)\n");
        _quotes.Add("\"The restored gospel of Jesus Christ proclaims the principle of full partnership between woman and man, both in mortal life and in the eternities. \nAlthough each possesses specific attributes and divinely appointed responsibilities, woman and man fill equally relevant and essential roles in \nGod’s plan of happiness for His children.\"(In partnership with the Lord, Elder Soares October 2022 General Conference)\n");
        _quotes.Add("\"True, enduring joy and eternity with those we love are the very essence of God’s plan of happiness.\"(Happy and Forever, Elder Gong October 2022 \nGeneral Conference)\n");
        _quotes.Add("\"Yet, none of us is perfect, nor is any family. Our relationships include love, sociality, and personality but often also friction, hurt, sometimes \nprofound pain.\"(Happy and Forever, Elder Gong October 2022 General Conference)\n");
        _quotes.Add("\"Each person who comes to earth is a unique son or daughter of God. Our personal journey did not begin at birth. Before we were born, we were \ntogether in a world of preparation where we “received [our] first lessons in the world of spirits.” Jehovah told Jeremiah, “Before I formed thee in the belly I knew thee; and before thou camest forth out of the womb I sanctified thee”\"(The Personal Journey of a child of \ngod, Elder Rasband April 2021 General Conference)\n");
        _quotes.Add("\"As covenant children of God, we love, honor, nurture, safeguard, and welcome those spirits who are coming from the premortal world.\"\n(The Personal Journey of a child of god, Elder Rasband April 2021 General Conference)\n");
        _quotes.Add("\"What is our responsibility as peaceful disciples of Jesus Christ? Let us live God’s commandments, teach them to our children, and share them with \nothers who are willing to listen.\"(The Personal Journey of a child of god, Elder Rasband April 2021 General Conference)\n");
        _quotes.Add("\"When asked where meaning comes in life, most people rank family first. This includes family living and gone before.\"(We Each Have a Story, \nElder Gong April 2022 General Conference)\n");
        _quotes.Add("\"God wants our families to be happy and forever. Forever is too long if we make each other unhappy. Happy is too short if cherished relationships \nstop with this life. Through sacred covenants, Jesus Christ offers His love, power, and grace to change us and heal our relationships.\"\n(We Each Have a Story, Elder Gong April 2022 General Conference)\n");
        _statement = ("position statement");
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Family:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Agency:Topics{

    public Agency(){
        _quotes.Add("\"The commandments and covenants He offers you are not tests to control you.\"(Legacy of Encouragement, President Eyring October 2022 General \nConference)\n");
        _quotes.Add("\"In contrast, those who deliberately choose wickedness, who consciously procrastinate repentance, or who in any premeditated or knowing way break \nthe commandments, planning for easy repentance, will be judged by God and a “bright recollection of all [their] guilt.”\"(Happy and Forever, \nElder Gong October 2022 General Conference)\n");
        _quotes.Add("\"I realized that every decision I would make for the rest of my life would be influenced by these truths.\"(Conversion to the will of God, Elder Cook\nOctober 2022 General Conference)\n");
        _quotes.Add("\"Agency is the ability and privilege God gives us to choose and to act for ourselves.” Thus, agency is at the heart of the personal growth and \nexperience that bless us as we follow the Savior.\"(Personal Peace in Challenging Times, Elder Cook October 2021 General Conference)\n");
        _quotes.Add("\"Moral agency is God’s precious gift to each of His children.1 We are “free to choose liberty and eternal life, through the great Mediator of all \nmen, or to choose captivity and death, according to the captivity and power of the devil.\"(Valiant Discipleship in the Latter Days, Elder Klebingat \nApril 2022 General Conference)\n");
        _quotes.Add("\"In the end we will therefore reap what our lifelong choices have sown. So what does the sum total of our thoughts, desires, words, and works say \nabout our love for the Savior, His chosen servants, and His restored Church?\"(Valiant Discipleship in the Latter Days, Elder Klebingat April 2022 \nGeneral Conference)\n");
        _quotes.Add("\"While some would prefer to be selective in the commandments they follow, let us joyfully accept the Savior’s invitation to “live by every word \nwhich proceedeth forth out of the mouth of God.”\"(Valiant Discipleship in the Latter Days, Elder Klebingat April 2022 General Conference)\n");
        _quotes.Add("\"Let us demonstrate our love for the Lord through wholehearted, voluntary obedience.\"(Valiant Discipleship in the Latter Days, Elder Klebingat April\n2022 General Conference)\n");
        _quotes.Add("\"If we really want to be valiant disciples of Christ, we will find a way.\"(Valiant Discipleship in the Latter Days, Elder Klebingat April 2022 \nGeneral Conference)\n");
        _quotes.Add("\"It has been said that “every day is election day, for throughout every hour of every day we each exercise our right of choice.\"(The Agency of Man, \nElder Vandenberg April 1973 General Conference)\n");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Agency:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Atonement:Topics{

    public Atonement(){
        _quotes.Add("\"When you sit with someone as their ministering sister or brother, you represent the Lord. Think of what He would do or say. He would invite them\nto come unto Him.\"(Legacy of Encouragement, President Eyring October 2022 General Conference)\n");
        _quotes.Add("\"He would notice and praise the beginning of the changes they will need to make. And He would be the perfect example for them to emulate.\"(Legacy of\nEncouragement, President Eyring October 2022 General Conference)\n");
        _quotes.Add("\"He can carry us today through difficult times. He did it for the early pioneers, and He will do it now for each one of us.\"(Follow Jesus Christ \nwith Footsteps of Faith, President Ballard October 2022 General Conference)\n");
        _quotes.Add("\"As the glorious Resurrection followed the agonizing Crucifixion, so blessings of every kind are poured out on those who are willing, as the Book of\nMormon prophet Jacob says, to “believe in Christ, and view his death, and suffer his cross.”\"(Lifted Up upon the Cross, Elder Holland October\n2022 General Conference)\n");
        _quotes.Add("\"I don’t want ... your time ... [or] your money ... [or] your work [as much as] I [just] want You. [That tree you are pruning.] I don’t want to cut\noff a branch here and a branch there, I want ... the whole [thing] down. [And that tooth.] I don’t want to drill [it], or crown it, or [fill] it. \n[I want] to have it out. [In fact, I want you to] hand over [to me your] whole natural self. ... [And] I will give you a new self instead. In fact,\nI will give you Myself: my ... will shall become [your will].\"(C.S.Lewis, referenced in, The Greatest Possession, Elder Holland October 2021 General Conference)\n");
        _quotes.Add("\"The Savior would declare, in no uncertain terms, that you are a daughter or son of the Almighty God. Your Heavenly Father is the most glorious\nbeing in the universe, full of love, joy, purity, holiness, light, grace, and truth. And one day He wants you to inherit all He has.\"(Jesus Christ \nis the Strength of Youth, Elder Uchtdorf October 2022 \nGeneral Conference)\n");
        _quotes.Add("\"Whatever the cause, it is human nature: without reliable landmarks, we drift off course.\"(Daily Restoration, Elder Uchtdorf October 2021 General \nConference)\n");
        _quotes.Add("\"that we have an “eternal destiny.” Such a destiny will not be forced on us. After death, we will receive what we have qualified for and “enjoy \n[only] that which [we] are willing to receive.” Realizing our eternal destiny is dependent on our choices. It requires making and keeping sacred \ncovenants.\"(Your Divine Nature and Eternal Destiny, Elder Renlund April 2022 General Conference)\n");
        _quotes.Add("\"Alma described this part of the Savior’s Atonement: “And he shall go forth, suffering pains and afflictions and temptations of every kind; and\nthis that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people”\"(Strengthened by the Atonement\nof Jesus Christ, Elder Oaks October 2015 General Conference)\n");
        _quotes.Add("\"God’s message is that, as President Russell M. Nelson has taught, “Repentance … is a process.” Repentance may take time and repeated effort, so \nforsaking sin and having “no more disposition to do evil, but to do good continually” are lifetime pursuits.\"(Worthiness is not Flawlessness, \nElder Wilcox October 2021 General Conference)\n");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Atonement:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Addiction:Topics{

    public Addiction(){
        _quotes.Add("\"The Savior knows your struggles in detail.\"(Legacy of Encouragement, President Eyring October 2022 General Conference)\n");
        _quotes.Add("\"So the primary battle is between our divine and spiritual nature and the carnal natural man.\"(Giving Our Spirits Control over Our Bodies, President\nBallard October 2019 General Conference)\n");
        _quotes.Add("\"when we choose to repent, we choose to change! We allow the Savior to transform us into the best version of ourselves. We choose to grow \nspiritually and receive joy—the joy of redemption in Him. When we choose to repent, we choose to become more like Jesus Christ!\"(Giving Our Spirits\nControl over Our Bodies, President Ballard October 2019 General Conference)\n");
        _quotes.Add("\"solemn reminders that there is a cost to discipleship.\"(Lifted Up upon the Cross, Elder Holland October 2022 General Conference)\n");
        _quotes.Add("\"All who speak in this general conference will all be saying, one way or another, what Christ said to this rich young man: “Come unto your Savior.\nCome completely and wholeheartedly. Take up your cross, however heavy it may be, and follow Him.”\"(The Greatest Possession, Elder Holland October \n2021 General Conference)\n");
        _quotes.Add("\"Jesus might point out that your covenants with Him—made when you were baptized and renewed each time you partake of the sacrament—give you a \nspecial connection with Him. The kind of connection the scriptures describe as being yoked together so that, with His help, you can carry any \nburden.\"(Jesus Christ is the Strength of Youth, Elder Uchtdorf October 2022 General Conference)\n");
        _quotes.Add("\"I don’t think He would make excuses for your mistakes. He wouldn’t minimize them. No, He would ask you to repent—to leave your sins behind, to\nchange, so He can forgive you.\"(Jesus Christ is the Strength of Youth, Elder Uchtdorf October 2022 General Conference)\n");
        _quotes.Add("\"Most of the changes in our spiritual lives—both positive and negative—happen gradually, a step at a time.\"(Daily Restoration, Elder Uchtdorf \nOctober 2021 General Conference)\n");
        _quotes.Add("\"Some mistakenly receive the message that they are not worthy to participate fully in the gospel because they are not completely free of bad habits.\nGod’s message is that worthiness is not flawlessness.\"(Worthiness is not Flawlessness, Elder Wilcox October 2021 General Conference)\n");
        _quotes.Add("\"“You’re not a hypocrite because you have a bad habit you are trying to break. You are a hypocrite if you hide it, lie about it, or try to convince\nyourself the Church has the problem for maintaining such high standards. Being honest about your actions and taking steps to move forward is not\nbeing a hypocrite.\"(Worthiness is not Flawlessness, Elder Wilcox October 2021 General Conference)\n");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Addiction:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Fasting:Topics{

    public Fasting(){
        _quotes.Add("\"The doctrine of fasting is ancient. It has been practiced by biblical heroes from the earliest days. Moses, David, Ezra, Nehemiah, Esther, Isaiah,\nDaniel, Joel, and many others fasted and preached of fasting.\"(Opening the Heavens for Help, President Nelson April 2020 General Conference)\n");
        _quotes.Add("\"“give yourselves to fasting and prayer.” The Savior Himself declared that certain things go “not out but by prayer and fasting.”\"(Opening the \nHeavens for Help, President Nelson April 2020 General Conference)\n");
        _quotes.Add("\"if we have a special purpose in our fasting, the fast will have much more meaning.\"(The Blessings of a Proper Fast, Elder Pratt October 2004 \nGeneral Conference)\n");
        _quotes.Add("\"Fasting can help us overcome personal flaws and sins.\"(The Blessings of a Proper Fast, Elder Pratt October 2004 General Conference)\n");
        _quotes.Add("\"Fasting without prayer is just going hungry for 24 hours. But fasting combined with prayer brings increased spiritual power.\"(The Blessings of a\nProper Fast, Elder Pratt October 2004 General Conference)\n");
        _quotes.Add("\"If the purpose of our fast is to be more effective in teaching the gospel and serving others in our Church callings, we are surely striving to \n“undo the heavy burdens” of others.\"(The Blessings of a Proper Fast, Elder Pratt October 2004 General Conference)\n");
        _quotes.Add("\"fasting brings us spiritual strength and prepares us to be resistant to the trials of this life.\"(Building a Life Resistant to the Adversary,\nElder Zeballos October 2022 General Conference)\n");
        _quotes.Add("\"My dear brothers and sisters, Alma received his witness by fasting and prayer more than 2,000 years ago, and we may have the same sacred experience\ntoday.\"(The Power of a Personal Testimony, Elder Uchtdorf October 2006 General Conference)\n");
        _quotes.Add("\"Fasting, coupled with mighty prayer, is powerful. It can fill our minds with the revelations of the Spirit. It can strengthen us against times of\ntemptation.\"(The Law of the Fast, Elder Wirthlin April 2001 General Conference)\n");
        _quotes.Add("\"If we want our fasting to be more than just going without eating, we must lift our hearts, our minds, and our voices in communion with our Heavenly\nFather.\"(The Law of the Fast, Elder Wirthlin April 2001 General Conference)\n");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Fasting:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Revelation:Topics{

    public Revelation(){
        _quotes.Add("\"God is the source of all truth. The Church of Jesus Christ of Latter-day Saints embraces all truth that God conveys to His children, whether \nlearned in a scientific laboratory or received by direct revelation from Him.\"(What is True, President Nelson October 2022 General Conference)\n");
        _quotes.Add("\"If you or I should go to the temple insufficiently pure, we would not be able to see, by the power of the Holy Ghost, the spiritual teaching\nabout the Savior that we can receive in the temple.\"(I Love to See the Temple, President Eyring April 2021 General Conference)\n");
        _quotes.Add("\"When we are worthy to receive such teaching, there can grow through our temple experience hope, joy, and optimism throughout our lives.\"(I Love to\nSee the Temple, President Eyring April 2021 General Conference)\n");
        _quotes.Add("\"He is teaching us how to become more spiritually self-reliant. He has said that “in coming days, it will not be possible to survive spiritually \nwithout the guiding, directing, comforting, and constant influence of the Holy Ghost.”\"(Follow Jesus Christ with Footsteps of Faith, President \nBallard October 2022 General Conference)\n");
        _quotes.Add("\"The scriptures also teach us how to receive personal revelation. And we ask for what is right and good and not for what is contrary to God’s will.\nWe do not “ask amiss,” with improper motives to promote our own agenda or to fulfill our own pleasure.\"(A framework for personal Revelation, Elder \nRenlund October 2022 General Conference)\n");
        _quotes.Add("\"A second element of the framework is that we receive personal revelation only within our purview and not within the prerogative of others.\"(A \nframework for personal Revelation, Elder Renlund October 2022 General Conference)\n");
        _quotes.Add("\"“Ask, and it shall be given you; … for every one that asketh receiveth.” With the help of the Holy Ghost, we can transform our divine nature into\nour eternal destiny.\"(A framework for personal Revelation, Elder Renlund October 2022 General Conference)\n");
        _quotes.Add("\"it is “the Holy Ghost ... [that] will show [us] all things [that we] should do.” When we are unsure or uneasy, we can ask God for help.\"(A \nframework for personal Revelation, Elder Renlund October 2022 General Conference)\n");
        _quotes.Add("\"Speculation will not lead to greater spiritual knowledge, but it can lead us to deception or divert our focus from what has been revealed.\"(Your \nDivine Nature and Eternal Destiny, Elder Renlund April 2022 General Conference)\n");
        _quotes.Add("\"Many on earth today are only kept from the truth because they know not where to find it.\"(What is True, President Nelson October 2022 General \nConference)\n");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Revelation:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.Write("\nPress Enter to continue: ");
        Console.ReadLine();
    }

}
class Temple:Topics{

    public Temple(){
        _quotes.Add("\"It is significant that the Savior chose to appear to the people at the temple. It is His house. It is filled with His power.\"(Focus on the Temple,\nPresident Nelson October 2022 General Conference)\n");
        _quotes.Add("\"They have not yet discovered that making and keeping covenants actually makes life easier!\"(Overcome the world and find Rest, President Nelson\nOctober 2022 General Conference)\n");
        _quotes.Add("\"The reward for keeping covenants with God is heavenly power—power that strengthens us to withstand our trials, temptations, and heartaches better.\"\n(Overcome the world and find Rest, President Nelson October 2022 General Conference)\n");
        _quotes.Add("\"because Jesus Christ overcame this fallen world, and because He atoned for each of us, you too can overcome this sin-saturated, self-centered, and\noften exhausting world.\"(Overcome the world and find Rest, President Nelson October 2022 General Conference)\n");
        _quotes.Add("\"The foundation of any building, particularly one as large as this one, must be strong and resilient enough to withstand earthquakes, corrosion,\nhigh winds, and the inevitable settling that affects all buildings.\"(The Temple and Your Spiritual Foundation, President Nelson October 2021 \nGeneral Conference)\n");
        _quotes.Add("\"Temple ordinances and covenants are ancient. The Lord instructed Adam and Eve to pray, make covenants, and offer sacrifices.\"(The Temple and Your\nSpiritual Foundation, President Nelson October 2021 General Conference)\n");
        _quotes.Add("\"If you and I are to withstand the forthcoming perils and pressures, it is imperative that we each have a firm spiritual foundation built upon the\nrock of our Redeemer, Jesus Christ.\"(The Temple and Your Spiritual Foundation, President Nelson October 2021 General Conference)\n");
        _quotes.Add("\"It is in the temple that we can receive the assurance of loving family connections that will continue after death and last for eternity.\"(I Love to\nSee the Temple, President Eyring April 2021 General Conference)\n");
        _quotes.Add("\"there came into my mind, not in my own voice, these words: “No, you have never been here before. You are remembering a moment before you were born.\nYou were in a sacred place like this.”\"(I Love to See the Temple, President Eyring April 2021 General Conference)\n");
        _quotes.Add("\"Our family was ready to leave that blessed time and place because a prophet, in a holy temple, a place of revelation, saw a future event for which\nwe then were prepared.\"(I Love to See the Temple, President Eyring April 2021 General Conference)\n");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Temple:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Service:Topics{

    public Service(){
        _quotes.Add("\"Yet Jesus taught them, “Love your enemies” and “do good to them that … despitefully use you.”\"(Love your Enemies, President Oaks October 2020 \nGeneral Conference)\n");
        _quotes.Add("\"As members of the restored Church, we need to be more aware and more appreciative of the service of others.\"(Helping the poor and Distressed, \nPresident Oaks October 2022 General Conference)\n");
        _quotes.Add("\"In this Easter season, Jesus Christ invites us to become, like Him, a good Samaritan, to make His Inn (His Church) a refuge for all from life’s \nbruises and storms.\"(Room in the inn, Elder Gong April 2021 General Conference)\n");
        _quotes.Add("\"Although we rarely think about it, much of our belonging comes from our service and the sacrifices we make for others and for the Lord.\"(The\nDoctrine of Belonging, Elder Christofferson October 2022 General Conference)\n");
        _quotes.Add("\"In service we find heaven-sent opportunities to rise above the individualism of our age.\"(The Need for a Church, Elder Oaks October 2021 General \nConference)\n");
        _quotes.Add("\"The same is true of faithful members who participate in the unselfish service we call “temple work.” None of such service would be possible without\nthe Church that sponsors it, organizes it, and directs it.\"(The Need for a Church, Elder Oaks October 2021 General Conference)\n");
        _quotes.Add("\"Our members’ religious faith and Church service have taught them how to work in cooperative efforts to benefit the larger community.\"(The Need for\na Church, Elder Oaks October 2021 General Conference)\n");
        _quotes.Add("\"First, we are commanded to serve one another. The first commandment is to love God. “And the second is like unto it, Thou shalt love thy neighbour\nas thyself.”\"(Service, Elder Snow October 2007 General Conference)\n");
        _quotes.Add("\"service is to be given unselfishly, with no thought of personal gain or reward.\"(Service, Elder Snow October 2007 General Conference)\n");
        _quotes.Add("\"Rather, look for ways to bless the lives of others through seemingly simple acts of service. It is better to do even things of little consequence\nthan to do nothing at all.\"(Service, Elder Snow October 2007 General Conference)\n");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Service:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}