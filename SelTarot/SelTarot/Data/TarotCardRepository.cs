using SelTarot.Models;

namespace SelTarot.Data
{
    public class TarotCardRepository
    {
        private static List<TarotCard> _cards = new List<TarotCard>
        {
       new TarotCard
{
    Id = 0,
    Name = "The Fool",
    ImagePath = "/images/tarot_cards/Fool.jpg",
    Description = "New beginnings, adventure, spontaneity",
    YesNoMeaning = false,
    Element = Element.None,
    AdditionalMeaning = "Joker kartı varoluşun öncesini temsil eder. Hayatınızda yaşanacak gelişmelerin tohumlarının atıldığını müjdeler. Bu süreçte risk alacağınızdan, kişisel gelişim yolculuğunuzda yepyeni bir sayfa açacağınızdan, kadersel bir dönüşüme gireceğinizden bahseder. Joker kartının size kattığı yolculuk bebek adımları atmak gibidir. Bu kart güzel gelişmeleri müjdelediği gibi size bazı uyarılar da verir. Hayatınızda sıfırdan başlayacağınız herhangi bir yolculukta dikkatli olmalı, her zaman iki kere düşünmelisiniz. Sizi uyaran dostlarınızı dinlemeli, daha önce deneyimlemediğiniz durumlarda tecrübeli birinden akıl danışmalısınız. Bu kart acemice başladığınız yolculuğunuzda size olgunluk katacak olaylardan bahseder. Bu yolculuğunuz riskli olabilir, size deneyimlerle geleceğinin farkında olmalısınız."
},
       new TarotCard
{
    Id = 1,
    Name = "Büyücü",
    ImagePath = "/images/tarot_cards/Magician.jpg",
    Description = "Yoktan var ediş, yaratıcılık, enerji",
    YesNoMeaning = false,
    Element = Element.None,
    AdditionalMeaning = "Büyücü kartı adeta yoktan var edecek enerjiyi bulmaktır. Kişinin aklındaki konu ile ilgili harekete geçmek için her şeye sahip olduğunu gösterir. Kişiye uzun süreli monotonluğun ardından hayata yeniden başlayacak enerjiyi verir. Kişinin artık sıfır noktasından bire geçtiğini anlatır. Bu kart size çıktıysa hayatınızda olmasını istediğiniz şeylerin gerçekleşeceğini, hayatın size her zaman olumlu ve “evet”lerle geleceğini söyler. Büyücü kartı içinizdeki potansiyeli ortaya çıkarır. Size mesajı ise daima hayatın size vereceği şeylere açık olmanızdır. Büyücü kartı size geldiyse verimliliği, bereketi, aşkı ile gelir. Size verilen hediyeyi almaya açık olmalı, bakış açınızı genişletmelisiniz."
},
     new TarotCard
{
    Id = 2,
    Name = "Azize",
    ImagePath = "/images/tarot_cards/HighPriestess.jpg",
    Description = "Dişil enerji, sezgi, bilgi",
    YesNoMeaning = false,
    Element = Element.None,
    AdditionalMeaning = "Azize kartı tarotun dişi enerjisidir. Kadınsı gücün simgesidir. Sessizliği ve sakinliği ile huzur verir ancak içerisinde çok fazla sır barındırır. Azize kartı sözü dinlenecek bir kadından bahseder. Kişiyi kendi iç dünyasını ve duygularını dinlemeye davet eder. Bu kartın mesajı kişinin sezgilerine güvenmesi gerektiğidir. Çevrenizde yaşanan durumları ve olayları, insanların duygu ve düşüncelerini sezebilirsiniz. Bu kart sizi bilmeye, ancak bilgiyi sessizce kullanmaya davet eder. Bu kart size geldiyse çevrenizdeki durumları sessizce gözlemleyecek, insanları tanımaya başlayacak, insanların iç dünyalarını görmeye başlayacaksınız demektir. Eğer bir olay veya durum karşısında yetersiz hissediyorsanız, azize kartı size duaları ve öğütleri ile (başka bir insan olarak) anaç bir enerji ile gelecektir. Azize kartı numarası itibari ile size dengeyi getirir ve doğru bir seçim yapmanızı sağlar."
},
       new TarotCard
{
    Id = 3,
    Name = "İmparatoriçe",
    ImagePath = "/images/tarot_cards/Empress.jpg",
    Description = "Bolluk, bereket, doğurganlık",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tarotun en güçlü kadını imparatoriçe, size bolluk ve bereketle geliyor. İmparatoriçe doğurganlığın ve bereketin simgesidir. Bu kart güçlü, zeki, başarılı, bolluk ve bereket içindeki özgüvenli bir kadından bahseder. Kişi maddi anlamda güzel haberler alabilir ve refaha kavuşabilir. Bir doğum haberini müjdeleyebilir. İmparatoriçe dişil enerjinin kuvvetlendirilmesinden de sorumludur. Bu kartla birlikte kişinin kendi dişi tarafına nezaket göstermesi gerekmektedir. Kişinin iç dünyasındaki büyüme dış dünyaya da yansır. İçten gelen kendine güven enerjisi kişinin iş, aşk veya sosyal hayatında da büyümeye başlar. Bu kartın mesajı kişinin kendi öz değerini fark etmesi üzerinedir. Bu kart size geldiyse kendi güzelliğinizi, gücünüzü, çekiciliğinizi fark etmelisiniz ve önceliğinizi kendiniz olarak belirlemelisiniz."
},
       new TarotCard
{
    Id = 4,
    Name = "İmparator",
    ImagePath = "/images/tarot_cards/Emperor.jpg",
    Description = "Güç, başarı, disiplin",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tarotun en güçlü erkeği imparator gücü, başarıyı ve disiplini simgeler. İmparator yön belirleyen, son noktayı koyan bir karttır. Akıl danışılabilecek bir erkek karakter olabileceği gibi, kişinin içindeki erili kullanmasından da bahsedebilir. İmparator eril enerjinin ta kendisidir. Gururdan, inattan ve hırstan bahsedebilir. İmparator genellikle düzenin ta kendisidir. Hayatı yoluna koymak, olgunlaşmak, geleceğe dair yatırım yapmaktır. Bu kart net bir hedefi de gösterebilir. Bu kart size geldiyse, size yardım edecek bir erkekten bahsediyor olabilir. Bu kişi size yön gösterebilir (bu kişi siz de olabilirsiniz). İşte, aşkta veya sosyal ilişkilerde net ve doğrucu olabilirsiniz. İstediğiniz şey için net, sabırlı ve istikrarlı bir yol izleyeceğinizi söyler."
},


      new TarotCard
{
    Id = 5,
    Name = "Aziz",
    ImagePath = "/images/tarot_cards/Hierophant.jpg",
    Description = "İnanç, gelenek, eğitim",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Aziz kartı kişinin içindeki inanç olgusundan bahseder. Kişinin kültürüne, alışkanlıklarına, eskiye olan bağlılığını gösterir. Bu kartın çıktığı kişiler yaşadıkları durumları çok eski bir kafayla yorumluyor olabilir. Kişi yüksek pozisyonda olan birinden bir destek veya iş alabilir. Babacan bir figürden hayat tavsiyesi edinebilir. Eğitim ve çalışma hayatından güzel haberler getirir. Kartın mesajı kişinin bakış açısını küçültmesi yönündedir. Çevrenizdeki bir erkek figürünü dinlemelisiniz. Belki de sorunlarınıza çok geniş bakıyorsunuzdur. Bazen kısa ve net cevaplar hayatımızı düzenlememiz ve sorunlarımızı çözmek için daha iyi bir seçenek olabilir."
},

      new TarotCard
{
    Id = 6,
    Name = "Aşıklar",
    ImagePath = "/images/tarot_cards/Lovers.jpg",
    Description = "Uyum, aşk, kadersel etkileşim",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Aşıklar kartı adından da anlaşılacağı üzere sonsuz uyumdan bahseder. İki insan arasında ruh bağı olabileceği gibi kadersel bir etkileşim de söz konusudur. Aşıklar kartı ikizler burcunu da temsil etmektedir. Eğer bu kart karşınıza çıktıysa, aşk hayatınızda güzel ve yüksek gelişimler yaşanacaktır. Bu kartın mesajı aşk hayatında iyileşmelerden bahseder. Hem kişinin iç dünyasında hem de dış dünyasında (ilişkilerinde) temizlenmeyi sembolize eder. Aşıklar kartı barışmayı ve ahenk yaratmayı da gösterir. Sadece aşk anlamında değil hayatın geri kalanında da yaratıcı fikirlerin ortaya çıkacağını, kişinin yolculuğun asla yalnız geçmeyeceğini anlatır. Aşıklar kartı size geldiğinde içiniz daima ferah olabilir. Hayat yolculuğunuzda karşılıklı çaba ve emek olacağını gösterir."
},
       new TarotCard
{
    Id = 7,
    Name = "Araba",
    ImagePath = "/images/tarot_cards/Chariot.jpg",
    Description = "Seçimler, kararlılık, zorlukların üstesinden gelme",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Araba kartı kişinin hayatındaki seçimlerden bahseder. Hayat size iki farklı seçenek sunmaktadır, bu seçenekler siyah ve beyaz kadar nettir. Kişi kararsızsa ve geleceğe dair önünü göremiyorsa araba kartı ona doğru yolu gösterir. Eğer bu kart karşınıza çıktıysa, bilin ki atacağınız adım sizin için uygun olacaktır. Araba kartı kişinin zor zamanlarının üstesinden geleceğini, gayretle uğraşacağını belirtir. Kartın mesajı ise kişinin her ne olursa olsun çaba göstermesidir. Kader size siyah ve beyaz olmak üzere iki seçenek sunmaktadır. Siz de ne olursa olsun kadere güvenerek sizin için en iyi yola girmek üzeresinizdir."
},

       new TarotCard
{
    Id = 8,
    Name = "Güç",
    ImagePath = "/images/tarot_cards/Strength.jpg",
    Description = "Toparlanma, içsel güç, motivasyon",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Güç kartı isminden de anlaşılacağı üzere koskocaman bir toparlanma kartıdır. Kişinin motivasyonunu neyden aldığını gösterir. Bu kartın mesajı şudur, acaba motivasyonunu, gücünü ve arzunu başkalarından mı alıyorsun? Güç kartı kişinin gücünün içten geldiğini belirtir. Eğer zorlandığınız bir anda karşınıza bu kart çıkıyorsa, bilin ki sizi ayağa kaldıracak şeyin yine kendiniz olduğunu hatırlatmaya çalışıyordur. Bu kart bir kişi için çekildiyse, bu kişinin gücünü sizden aldığını söyleyebiliriz. Birisi sayesinde hayata dönmeyi, hayat motivasyonunu kazanmayı gösterir."
},

       new TarotCard
{
    Id = 9,
    Name = "Ermiş",
    ImagePath = "/images/tarot_cards/Hermit.jpg",
    Description = "İçe dönme, içsel keşif, yalnızlık",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Ermiş kartı tarotun en içe dönük kartıdır. Anlamı kişinin sorularının cevaplarını kendi iç dünyasında bulacak olmasıdır. Bu kart kişinin yalnızlaşacağı, kendi içine dönüp hayatla ilgili sorularını cevaplayacağını anlatır. Kişi ermişle birlikte bir dağın zirvesine çıkar ve her şeyi daha net görür. Bir nevi kara bulutların dağılmasını sağlar. Aklınızdaki konunun kaynağına inmenizi sağlar. Bu kart kişinin biraz ketum olması gerektiğini anlatır. Başınıza gelen iyi veya kötü durumları biriyle paylaşmak güncel durumda pek iyi olmayabilir. Bir ilişkiyi, iş haberini veya eğitim durumunu şimdilik paylaşmamanızı önerir."
},

     new TarotCard
{
    Id = 10,
    Name = "Kader Çarkı",
    ImagePath = "/images/tarot_cards/Wheel_of_Fortune.jpg",
    Description = "Büyük değişim, kader, dönüm noktası",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Hayatımızda pek çok çark vardır. Bu çarkların bazılarını değiştirebilir, bazıları ise çok büyüktür. Bu büyük çarklar bizim kaderimizdir. Bu kartla birlikte hayatınızda büyük bir değişimin gerçekleşeceği kaçınılmazdır. Hayatınızda önemli bir karar alabilir, değişikliğe gidebilir, hayatınızı değiştirecek insanlarla karşılaşabilirsiniz. Yani gözünüzü dört açmanız çok önemlidir. Bu kart karşınıza çıktıysa hayatınızla ilgili büyük bir mesaj vardır. Bu süreçte çevrenizdeki insanlara, aldığınız kararlara dikkat etmelisiniz. Algınızı en iyisi ve en güzeli için açmanız gerek. Kader çarkı en güzeli ve en hayırlısı ile sizin için dönmekte. Kadere güvenin ve devam edin."
},

     new TarotCard
{
    Id = 11,
    Name = "Adalet",
    ImagePath = "/images/tarot_cards/Justice.jpg",
    Description = "Karma, denge, sonuç",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Adalet kartı bir nevi bize karmadan bahseder. Kişinin hayatında karşılığını alamadığı her şeyin teker teker alınacağından bahseder. Yaşadığınız acının, zorluğun karşılığını ilahi adalet size sağlamak üzere. Adalet kartı beklenen bir haberin gelmesi olarak da yorumlanabilir. Uzun zamandır beklenen bir davanın veya meselenin sonuçlanacağını söyler. Kartın mesajı kişinin ektiğini biçmesidir. Yani yapılan iyilik de kötülük de ilahi adalet tarafından cevapsız kalmayacaktır."
},


      new TarotCard
{
    Id = 12,
    Name = "Asılan Adam",
    ImagePath = "/images/tarot_cards/Hanged_Man.jpg",
    Description = "Kişisel mücadele, kendini cezalandırma, özgürleşme",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Asılan Adam hayatımızda bitmek bilmeyen bir mücadele olduğunu ve bu mücadelenin bütün yıkımını kişinin kendisinin üstlendiğini söyler. Kişinin kendini fazlaca cezalandırdığını ve hayattan elini çektiğini anlatır. Bu kartı çeken kişi kendini fazlaca soyutlamış ve cezalandırıyor olabilir. Ancak kişi kendi zincirlerinin anahtarının da cebinde olduğunu bilmelidir. Özgürleşmek için yapılması gereken ilk şey hatanın ve tüm ağır sorumluluğun kişinin kendi üzerine yıkmaması olacaktır."
},

       new TarotCard
{
    Id = 13,
    Name = "Ölüm",
    ImagePath = "/images/tarot_cards/Death.jpg",
    Description = "Son, dönüşüm, yeni başlangıç",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Ölüm kartı tarotun en yanlış anlaşılan kartlarından biridir. Bu kart kişinin hayatındaki yüklerden ve zararlı araçlardan kurtulacağından bahseder. Her dizide sezonlar olduğu gibi bizlerin de hayatında sezonlar vardır. Ölüm kartı kişinin yeni bir sezona gireceğinden, onu zehirleyen her şeyden kurtulacağını anlatır. Ölüm kartı geldiyse, kişi özel hayatından birilerini çıkarabilir, kendine yeni ilişkiler kurabilir. Bu kart bize bitişlerden bahsettiği gibi, kaçınılmaz fırsatların gelişini de müjdeler. Hayatınızdaki bazı noktalarda kaçınılmaz bir sona yaklaştığınızı anlatır. Ölüm kartının getirdiği değişiklikler size başta zor gelse de, sonunda size daimi bir huzur ve yenilik getirir."
},
      new TarotCard
{
    Id = 14,
    Name = "Denge",
    ImagePath = "/images/tarot_cards/Temperance.jpg",
    Description = "Huzur, denge, uyum",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Denge kartının genel mesajını “Su akar yolunu bulur.” şeklinde özetleyebiliriz. Denge kartı hayatımıza sakinliğin ve huzurun geleceğini müjdeler. Aynı zamanda kayıp yapboz parçasını kişisel sürecinizde bulacağını da söyler. Denge kartı açılımınızda geldiyse anlayın ki aklınızdaki bir durum ve düşünce zamanla şifalanacak. Duygularınızı kontrol altına almayı öğreneceksiniz. Hayatınızdaki her şey aşama aşama gerçekleşecek. Yaşanan bir olay başka bir olayı destekleyecek. Katlanan bir huzur sizi bekleyecek. Bu süreçte inatçı olmamalı, zamanın akışına güvenmelisiniz. Anı yaşamalı ve planlara bağlı kalmamalısınız."
},
      new TarotCard
{
    Id = 15,
    Name = "Şeytan",
    ImagePath = "/images/tarot_cards/Devil.jpg",
    Description = "Bağımlılıklar, esaret, maddi bereket",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Şeytan kartı destenin en korkutan kartlarındandır ancak hem iyi hem de kötü yanları ile kişiyi uyarır. Şeytan kartı kişinin bazı konularda bağımlılıklarının seviyeyi aştığından bahseder. Kişinin akışa karşı direndiğini ve kendi takıntılarının onu yönettiğini gösterir. Bu bağımlılık kişiye, paraya, işe karşı olabilir. Kartın mesajı kişinin hayatını etkileyen bağımlılıklara karşı kendini korumasıdır. İçinde bulunduğunuz esarete kendinizi gönüllü olarak kaptırmış olabilirsiniz. Gözlerinizi açmalı ve sizin için en sağlıklı olacak seçeneğe yönelmelisiniz. Yasak bir aşkın, hayırsız bir meselenin içinde olabilirsiniz. Bu kartın maddi durumdaki karşılığı ise sanılanın aksine güzeldir. Eğer meseleniz maddi durumlarla ilgiliyse size gelecek bereketin habercisidir."
},
      new TarotCard
{
    Id = 16,
    Name = "Kule",
    ImagePath = "/images/tarot_cards/Tower.jpg",
    Description = "Yıkım, ani değişim, yeniden yapılanma",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Kule kartı tarotun yıkım kartıdır. Kişinin aniden bir yıkım yaşayacağından bahseder. Bu yıkım kişide yoğun bir şok etkisi yaratabilir. Bir anda tüm düzeni sarsılabilir. Hayatın alt üst olma durumundan bahseder. Ancak kişi kule kartını gördüğünde korkmamalıdır. Kule kartı size toparlanacak bir enkazdan bahseder. Yeniden bir ev inşa edileceğini söyler. Kişi küllerinden doğacaktır. Hayatın getirdiği ani yükün ardından temizlenecek ve kendinize sıfırdan bir düzen kuracaksınız. Kartın mesaji kişinin ani değişimlerden korkmaması ve hayatın getirdiği şeylerin sorumluluğundan kaçmamasıdır."
},
 new TarotCard
{
    Id = 17,
    Name = "Yıldız",
    ImagePath = "/images/tarot_cards/Star.jpg",
    Description = "Yenilenme, umut, şifa",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Yıldız kartı yenilenmenin ta kendisidir. Kişinin hayatındaki tüm kirleri içinden boşaltmasıdır. Uzun zamandır yaşanan kırgınlığın atılması, kara bulutların dağılmasıdır. Kişinin hayatındaki her şeyi affedeceğini, yüklerinden kurtulacağını ve enerjisinin yenileceğini söyler. Bu kart kişiye geldiyse mesajı kesinlikle yıldızının parlayacağıdır. Çektiğiniz onca acıya değdi, der. Size affetmeniz ve kendi yolunuza gidebilmeniz için fırsat tanır. Kişinin hayatında, ilişkisinde, aklındaki durumunda iyileşmenin başladığını simgeler."
},
  new TarotCard
{
    Id = 18,
    Name = "Ay",
    ImagePath = "/images/tarot_cards/Moon.jpg",
    Description = "Bilinçaltı, korkular, sırlar",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Ay kartı tarotta oldukça önemli ve ciddi bir karttır. Pek çok anlamı vardır ve uyarılarını dinlemeniz gerekir. Kişinin bilinçaltına kulak vermesi gerektiğini söyler. Ay kartı size geldiyse korkularınızdan ve sırlarınızdan arınmanız gerektiğini söyler. İçinizde biriktirdiğiniz korkuların dışarı atılması gerektiğinden bahseder. Bu kart geldiyse çevrenizde size yalan söyleyen, size karşı kötü niyetli olan kimseler olabilir. Partneriniz sizden bir şey gizliyor veya size karşı bir sırrını açamıyor. Ketum olmalı ve çevrendekileri anlamak için onları dinlemelisin. Herkesin kim olduğunu fark edecek ve öğreneceksin. İkili ilişkilerinizde saklı korkularınız, travmalarınız, ailenizden gelen sorunlar sizi çok fazla etkiliyor olabilir. Duygusal değil daha mantıksal hareket etmenin vakti gelmiş. Artık sizi travmalarınızın değil sağlıklı düşüncelerinizin kontrol etmesini sağlamalısınız."
},
new TarotCard
{
    Id = 19,
    Name = "Güneş",
    ImagePath = "/images/tarot_cards/Sun.jpg",
    Description = "Başarı, neşe, olumlu gelişmeler",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Güneş kartı tarotun en olumlu ve güçlü kartıdır. Bu kart size aklınızdaki durum ve düşüncenin kesinlikle en iyi ve en başarılı şekilde gerçekleşeceğinden bahseder. Güneş kartı negatif düşüncelerin pozitife geçeceğinden, önyargıların ve korkuların biteceğini söyler. Bu kart size geldiyse enerjiniz değişecek, insanların dikkatini çekecek ve büyük bir başarıya adım atacaksınız demektir. Nazar değmemesi için dikkat etmelisiniz. Bu kart geldiyse eğer gözyaşlarınız hüzün değil sevinçten akacaktır. Ayrıca güneş kartı yaz aylarında gerçekleşecek olumlu haberlerden, hamilelik, kazanç veya yeni bir aşktan da bahseder."
},



      new TarotCard
{
    Id = 20,
    Name = "Mahkeme",
    ImagePath = "/images/tarot_cards/Judgement.jpg",
    Description = "Hukuk, yüzleşme, yeni başlangıç",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Mahkeme kartı adından da anlaşılacağı üzere hukuk ve adalet konularından bahsedebilir. Bu kartla birlikte bir davanız, durumunuz sonuçlanabilir. Hakkınızı alma yolunda adım atabilirsiniz. Mahkeme kartı bir skandalı, sırrı öğreneceğinizden bahseder. Karşılıklı yüzleşmelerin habercisidir. Biriyle görüşebilir, bir konu hakkında ciddi bir konuşma yapabilirsiniz. Geçmişten biri hayatınıza girebilir ve o kişiyle içinizdeki her şeyi konuşabilirsiniz. Mahkeme kartı iş görüşmelerinden ve yeni başlangıçlardan da bahseder. Hayatınızdaki engellerin kalkıp artık görüşmelerin ve yeniliklerin başlayacağını gösterir."
},


    new TarotCard
{
    Id = 21,
    Name = "Dünya",
    ImagePath = "/images/tarot_cards/World.jpg",
    Description = "Tamamlanma, başarı, yeni başlangıç",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Dünya kartı yeni başlangıçların ve kişinin yeni bir sezona başladığını gösterir. Kişi artık bir yenilenme sürecine girmektedir. Artık hayatında bir mutlu sonun gerçekleşeceğini söyler. Dünya kartı bize bir tamamlanmayı da anlatır. Dünya kartı beklenilen bir haberin geleceğini, geçmişten bir insanın geri döneceğini de söyler. Bu kartla birlikte bir durumun, haberin veya kişinin hayatımıza tekrardan geleceğini ve tamamlanacağını anlatır. Artık zafere ulaştınız ve rahat bir nefes alabilirsiniz. Yapmanız gereken tek şey sürece güvenmek ve kibrinize yenilmemek. Dünya kartı size öyle güzelliklerle gelir ki insanın şımarmasına sebep olabilir. Bu süreçte iyi niyetli olmayı unutmamalısınız."
},


      new TarotCard
{
    Id = 22,
    Name = "Tılsım Ası",
    ImagePath = "/images/tarot_cards/Ace_of_Pentacles.jpg",
    Description = "Somut gelişmeler, maddi ilerleme, teklifler",
    YesNoMeaning = true,
    Element = Element.Earth,
    AdditionalMeaning = "Aslar tarotta başlangıçlardan bahsederler. Bu kart size geldiyse hayatınızda somut gelişmeler yaşanacağını, bir teklifle veya özürle karşılaşacağınızı söyler. Bu kartla birlikte hayatınızda net gelişmeler olacaktır. Maddi boyutta ilerleme kaydedeceğinizi söyler. Hayatınızda net kararlar alacağınız, kendinizi güvenceye alacağınız bir döneme giriş yapmaktasınız. Bu kartla birlikte bir evlilik teklifi, çocuk haberi, özür veya mesaj alabilirsiniz."
},


     new TarotCard
{
    Id = 23,
    Name = "Tılsım İkilisi",
    ImagePath = "/images/tarot_cards/Two_of_Pentacles.jpg",
    Description = "Seçenekler arasında denge, kafa karışıklığı",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Bu kart kişinin seçenekler arasında git-geller yaptığını söyler. Hayat size iki seçenek sunuyor, birini seçmeli ve geçmiş-gelecek arasındaki dengeyi sağlamalısınız. Bu kart kişinin kafasının çok karışık olduğundan, doğru kararı verememesinden bahseder. Bu kart size geldiyse duygusal davranmamalısınız. Sizin için doğru ve net olan kararı vermelisiniz. Bu kart sizi hayatınızdaki en önemli şeyi bulmanızı ve seçmenizi işaret ediyor."
},


new TarotCard
{
    Id = 24,
    Name = "Tılsım Üçlüsü",
    ImagePath = "/images/tarot_cards/Three_of_Pentacles.jpg",
    Description = "Ekip çalışması, destek, emek",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım üçlüsü kişinin hayatındaki ekip çalışmalarından ve yardımlardan bahseder. Hayatınızda başkalarından destek alacağınız, aklınızdaki konu ile ilgili ince ince çalışacağınızı söyler. Hayatınızdaki tüm yükü ve sorumluluğu kendinize yüklemiş olabilirsiniz. Ancak bu süreçte başkalarını dinlemeyi bilmeli, hayatınız, işiniz, partneriniz için ince ince çalışmak ve emek vermek gerektiğini anlamalısınız. Her şeyin karşılığı sevgi ve emektir."
},


        new TarotCard
{
    Id = 25,
    Name = "Tılsım Dörtlüsü",
    ImagePath = "/images/tarot_cards/Four_of_Pentacles.jpg",
    Description = "Bağımlılık, geçmiş acılar, döngü",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım dörtlüsü bize alışkanlıklarımızın bağımlılığa dönmesinden bahseder. Geçmişten gelen acılarımızın ve deneyimlerimizin bizi çok fazla etkilediğini, bu nedenle geleceğe yönelik yeni bir başlangıç yapamadığımızı anlatır. Ancak bu döngüyü kırmak sizin elinizde. Siz bu döngünün sadece birazcık gerisindesiniz. Düşünmek için aklınızı, sevmek için kalbinizi, ileriye yürümek için ayaklarınızdaki düğümlenmiş ipi açmalısınız. Bu döngüden çıkmak için kalbinizdekini söylemeli ve yapmalısınız."
},


       new TarotCard
{
    Id = 26,
    Name = "Tılsım Beşlisi",
    ImagePath = "/images/tarot_cards/Five_of_Pentacles.jpg",
    Description = "Maddi sıkıntılar, aile huzursuzluğu, sosyal destek",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım beşlisi büyük bir uyaran karttır. Maddi anlamda sıkıntıya, aile içinde huzursuzluğa işaret eder. Bu durumda kişinin kendini hem aile hayatından hem de genel olarak her yerden kendini soyutladığından bahseder. Kişinin bu durumda sosyal hayatına önem vermesi, yalnız kalmaması, mutlaka derdini açması gerekmektedir."
},

    new TarotCard
{
    Id = 27,
    Name = "Tılsım Altılısı",
    ImagePath = "/images/tarot_cards/Six_of_Pentacles.jpg",
    Description = "Alma-verme dengesi, karşılık alma",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım altılısı alma verme dengesinden bahseder. Sürekli almaya veya vermeye mi bağımlısınız? Bu kartla birlikte hayatınızdaki bazı durumları gözden geçirmeniz gerekmektedir. Hayatınızdaki dengesizliklere bir bakın, sevginizin, paranızın, emeğinizin karşılığını almaya gayret gösterin. Değer görmediğiniz yerlerde durmayın. En az bir o kadar da hayatın size sunduklarını kabul edin. Hayat size son zamanlarda her şeyi damla damla veriyor olabilir. Bu durumda bencillik yapmak veya isyan etmek yerine bu damlaların bir gün göle dönüşeceğini anlayın."
},

       new TarotCard
{
    Id = 28,
    Name = "Tılsım Yedilisi",
    ImagePath = "/images/tarot_cards/Seven_of_Pentacles.jpg",
    Description = "Bereket, yavaş meyve verme, hayalkırıklığı",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım yedilisi hak edileni ustaca almaktır. Hayat size yavaş yavaş meyvesini vermeye başlamıştır. Kişi bereketine kavuşmaya başlayacaktır. Eğer hayalkırıklıkları yaşadığınız, pes etme noktasına geldiğiniz bir dönemde bu kart size geldiyse bilin ki hayat size bollukları ile geliyor. Bu kart kişinin istediği adımı, parayı, işi elde edeceğini söyler ancak kişi bunun yavaş ve hayırlısı ile geleceğini bilmelidir."
},

      new TarotCard
{
    Id = 29,
    Name = "Tılsım Sekizlisi",
    ImagePath = "/images/tarot_cards/Eight_of_Pentacles.jpg",
    Description = "Aile planlaması, ilişki, değerli planlar",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım sekizlisi bir aile planlamasıdır. Kişinin bir aile kurmak istediğini, gelecek planlarına partnerini de eklediğini, gitmek istediği yerleri haritada çizdiğini gösterir. Bu kartı çeken kişi yeni bir ilişkiye başlayacak, aile hayatı düzene girecek, istediği ortamda istediği saygınlığa ulaşacaktır. Bu kart plan yapmaktan da bahseder. Planların artık teoriden pratiğe geçeceğini, birer birer gerçekleşeceğini söyler. Artık kendinizden emin olma vaktiniz geldi. Kendinizi değerli hissedecek, sizi ilgilendirmeyen konularda üzülmeyi veya dert etmeyi bırakacaksınız."
},

     new TarotCard
{
    Id = 30,
    Name = "Tılsım Dokuzlusu",
    ImagePath = "/images/tarot_cards/Nine_of_Pentacles.jpg",
    Description = "Maddi ve manevi doyum, öz saygı",
    YesNoMeaning = true,
    Element = Element.Earth,
    AdditionalMeaning = "Bu kart tılsımların en parıltılı ve en güzel kartıdır. Kişinin maddi manevi doyuma ulaşacağını, çevresi tarafından kıskanılacağını, enerjisel anlamda temizleneceğini anlatır. Kişi artık istediği her şeyi gerçekleştirmeye ve kendi öz saygısını tamamen kazanmaya başlar."
},
       new TarotCard
{
    Id = 31,
    Name = "Tılsım Onlusu",
    ImagePath = "/images/tarot_cards/Ten_of_Pentacles.jpg",
    Description = "Aile hayatında başarı, tamamlanma, huzur",
    YesNoMeaning = true,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım onlusu kişinin aile hayatında, ilişkisinde, aşkında başarıya ulaşacağını ve tamamlanacağından bahseder. Kişi evi diyebileceği insanı bulacak ve ilişki içinde de tamamlanmış hissedeceğinden bahseder. Her şey yerli yerine oturacak, ciddi bir ilişkiye başlanacaktır. Yeni bir döngü başlayacak ve her şey daha da iyi olacaktır. Bu kart bize evlilikten, yeni bir ilişkiden, aile hayatında huzurdan bahseder. Hayat size toz pembe bir dönem sunacaktır. Keyfini çıkarmaya bakın."
},

      new TarotCard
{
    Id = 32,
    Name = "Tılsım Prensi",
    ImagePath = "/images/tarot_cards/Page_of_Pentacles.jpg",
    Description = "Şımarık, genç, planlı kişi",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım prensi hayatınızdaki “şımarık” denebilecek toy birinden bahseder. Bu kişinin yaşı gençtir, ailesi tarafından ilgi görmüştür. Bu kişi ağır çalışır, bir anda adım atmaz. Planlı ve programlı ilerler, her ne kadar toy da olsa nettir ve kararlarının arkasında durur."
},

       new TarotCard
{
    Id = 33,
    Name = "Tılsım Şövalyesi",
    ImagePath = "/images/tarot_cards/Knight_of_Pentacles.jpg",
    Description = "İstikrarlı, sabırlı, planlı kişi",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım şövalyesi adım atacak birinden bahseder. Bu kişi çok istikrarlıdır ve sabırlıdır. Atacağı tüm adımları öylesine planlar ki hedefleri uğuna aylarca beklemeyi dahi göze alır. Basamakları teker teker çıkacak, en sonunda da istediği şeyi elde edecektir."
},

     new TarotCard
{
    Id = 34,
    Name = "Tılsım Kraliçesi",
    ImagePath = "/images/tarot_cards/Queen_of_Pentacles.jpg",
    Description = "Dişil enerji, bekleyiş, sadakat",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım kraliçesi dişil enerjiyi temsil eden önemli kartlardan biridir. Bu kadın sürekli bir bekleyiş içerisindedir. Bu bekleyiş bir adım da olabilir maddi bir karşılık da… Bu kadın birini sever ve güvenirse ona daima sadık kalır ve uğruna yıllarca bekleyebilir. O da diğer tılsım üyeleri gibi her konuda nettir. Bu karakter ayrıca doğurganlığı, anneliği ve ten uyumunu da gösterir."
},


     new TarotCard
{
    Id = 35,
    Name = "Tılsım Kralı",
    ImagePath = "/images/tarot_cards/King_of_Pentacles.jpg",
    Description = "Motivasyonu yüksek, azimli, manipülatif",
    YesNoMeaning = false,
    Element = Element.Earth,
    AdditionalMeaning = "Tılsım kralı motivasyonu yüksek, hayatta daima istediğini elde etmiş hırslı biridir. Aşk hayatında manipülatif olabilir. İstediğini elde etmek için her şeyi yapabilir. Sürekli plan yapan, para ve iş gibi konularda istekli ve azimli olan biridir. Bu kişiyle konuşurken ılımlı olmalısınız. Bu kişi ilişkiye değer verdiğinde çok sadık ve nettir. Bu kişinin sözleri ilk başta çok romantik ve dolu dolu gelebilir, ancak dikkat edilmelidir. İstediğini elde edene kadar her şeyi yapabilir."
},

      new TarotCard
{
    Id = 36,
    Name = "Değnek Ası",
    ImagePath = "/images/tarot_cards/Ace_of_Wands.jpg",
    Description = "Harekete geçme enerjisi, yeni başlangıçlar",
    YesNoMeaning = true,
    Element = Element.Fire,
    AdditionalMeaning = "Değnekler bize harekete geçme enerjisinden bahsederler. Bu kart hayatınızda şansın geri döneceğini, hayatınızla ilişkili bir takım planlar yapacağınızdan bahseder. Artık aklınızdaki planı teoriden uygulamaya dökmeye başlama vaktiniz geldi. Özellikle akademik veya kariyer anlamında büyük adımlar gelmek üzere. Uzun zamandır yataktan dahi çıkamıyor veya uygun motivasyonu bulamıyor olabilirsiniz. Değnek ası size gerekli motivasyonu ve gücü vermeye geliyor."
},
      new TarotCard
{
    Id = 37,
    Name = "Değnek İkilisi",
    ImagePath = "/images/tarot_cards/Two_of_Wands.jpg",
    Description = "Sabır, merak, sosyal medya izleme",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Değnek ikilisi uzun zamandır beklenen bir şeyin veya durumun güzel sonuç vereceğinden bahseder. İstediğiniz şey uğruna sabırlı olmanız gerektiğini, birkaç aylık bekleyişin sonucunu alacağınızı söyler. Tarotta iki sayısı seçimlerden de bahsetmektedir. Uygun adımı atacak gücü bulacak ve kendinize yeni hedefler izleyeceksiniz. Bu kart aynı zamanda merak ve stalk kartıdır. Hayatınızdan çıkmış birisi veya hayatınıza yeni girmekte olan birisi sürekli sizi merak ediyor, sizi izliyor ve sosyal medya hesaplarınıza bakıyor olabilir."
},
    new TarotCard
{
    Id = 38,
    Name = "Değnek Üçlüsü",
    ImagePath = "/images/tarot_cards/Three_of_Wands.jpg",
    Description = "Bekleyişin sonuçlanması, yeni bakış açıları",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Değnek üçlüsü bir bekleyişin sonuçlanmasından bahseder. Uzun süredir istediğiniz bir şey veya yolunu gözlediğiniz bir durum olabilir. Bu durumun ve bekleyişin artık son bulacağını, kişinin özgüvenini ve dirayetini geri kazanacağını söyler. Bu kart size geldiyse bilin ki artık iyi bir görüş açısı kazanacaksınız, bakış açınız güçlenecek. Çevrenizdeki sosyal ilişkileri üçüncü bir gözle inceleyecek ve hayatınızdaki insanların niyetini görmeye başlayacaksınız."
}
,
    new TarotCard
{
    Id = 39,
    Name = "Değnek Dörtlüsü",
    ImagePath = "/images/tarot_cards/Four_of_Wands.jpg",
    Description = "Güçlü aile bağları, kutlamalar, aşk",
    YesNoMeaning = true,
    Element = Element.Fire,
    AdditionalMeaning = "Değnek dörtlüsü karşınıza çıktıysa sevinmelisiniz. Çünkü kendisi güçlü ve huzurlu aile bağlarından, doğumdan, bereketten ve güçlü ikili ilişkilerden haber getirir. Hayatınızda kutlamaların bollaşacağı bir döneme girmektesiniz. Eğer hayatınızda birisi yoksa yakın zamanda aşk hayatınızda gerçek uyumu bulacağınız, yeni bağlar kuracağınız, geçmiş toksik ilişkilerinizden arınacağınız bir döneme girmektesiniz demektir."
},
new TarotCard
{
    Id = 40,
    Name = "Değnek Beşlisi",
    ImagePath = "/images/tarot_cards/Five_of_Wands.jpg",
    Description = "Kafa karışıklığı, zıtlaşma, yalnızlık",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Bu kart size geldiyse hayatınızda çok fazla kafa karışıklığı var demektir. Kafanızın içindeki düşünceler bir sağa bir sola gidiyor olabilir. Çevrenizdeki insanlarla çok fazla zıtlaşıyor veya size uygun olmayan ortamlarda bulunuyor olabilirsiniz. Partnerinizle çok fazla kavga ediyor ve basit tartışmaları bile kafanızda büyüterek zorlaştırıyor olabilirsiniz. Bu kart kişinin bir savaş ortamında yapayalnız kaldığını anlatır. Bu kart size kendinizi sevmeniz gerektiğini, kendinizi ait hissetmediğiniz ortamlardan uzaklaşmanız gerektiğini söyler. Sosyal ilişkilerinizde biraz mola verebilir, farklı bakış açılarından düşünmeyi veya empati kurmayı düşünebilirsiniz."
},
  new TarotCard
{
    Id = 41,
    Name = "Değnek Altılısı",
    ImagePath = "/images/tarot_cards/Six_of_Wands.jpg",
    Description = "Başarı, takdir, uyumlu ilişki",
    YesNoMeaning = true,
    Element = Element.Fire,
    AdditionalMeaning = "Bu kart tarotun belki de en güzel kartlarından biridir. Kişinin bulunduğu ortamda dikkat çekeceğini, insanların ona imreneceğini ve başarısını takdir edeceğini söyler. Aklınızdaki durum veya düşünce ile ilgili başarıya ulaşacağınızdan, mutlaka doğru yolun rahatlıkla bulunacağından bahseder. Bu kart aynı zamanda bir ilişki kartıdır. İlişkiniz daha iyiye gidebilir, ciddi kararlar alınabilir, evlilik veya nişan gibi durumlar olabilir. Hayatınızda başkalarının dikkatini çeken uyumlu ve güzel bir ilişkiniz olabilir. Hayatınızda biri yoksa hızlı başlangıçlar yapabilir ve hızlı bir aşka yelken açabilirsiniz."
},
new TarotCard
{
    Id = 42,
    Name = "Değnek Yedilisi",
    ImagePath = "/images/tarot_cards/Seven_of_Wands.jpg",
    Description = "Zorlama, direniş, sorunları çözme",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Bu kart size geldiyse bir şeyleri çok fazla zorluyorsunuz demektir. Hayatınızla ilgili çok fazla derdiniz olabilir ancak bu dertleri tek bir ortak paydada birleştirip çözemezsiniz. Pes etmeden veya savaşmadan önce bir durmalı ve liste yapmalısınız. Hayatınızla ilgili direndiğiniz ancak çözmek zorunda olduğunuz meseleleri düşünmeli ve önceliklerinize göre yavaş ve sabırlı şekilde onları çözmelisiniz. Bazen kişinin sorun sandığı şeyler basit olabilir. Bunun aksine sizi güvende hissettiren bazı şeyler ise size büyük zararlar verebilir. Bu kartla birlikte hayatınızda size gerçekten iyi gelen veya gelmeyen şeyleri düşünmelisiniz."
},
new TarotCard
{
    Id = 43,
    Name = "Değnek Sekizlisi",
    ImagePath = "/images/tarot_cards/Eight_of_Wands.jpg",
    Description = "Tamamlanma, hızlı değişim, ilişki",
    YesNoMeaning = true,
    Element = Element.Fire,
    AdditionalMeaning = "Değnek sekizlisi hayatınızda bir türlü tamamlanmayan veya havada kalan bazı şeylerin artık son bulacağından ve rahat bir nefes alacağınızdan bahseder. Artık hayatınızın hızlı bir dönemine girmiş bulunmaktasınız. Bu dönemde alacağınız kararlara dikkat etmeli ve hızla birlikte kaybolmamaya çalışmalısınız. Eğer bir ilişkiniz varsa hızlı bir şekilde ilerleyebilir ve ciddileşebilirsiniz. Yoksa da yeni ilişkiniz hayatınıza hızlı bir şekilde girecek, sizi şaşırtacak derecede tamamlanmış ve huzurlu hissettirecektir."
},
new TarotCard
{
    Id = 44,
    Name = "Değnek Dokuzlusu",
    ImagePath = "/images/tarot_cards/Nine_of_Wands.jpg",
    Description = "Pes etme noktası, derin sıkıntılar",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Bu kart sizin artık pes etme noktasına gelecek kadar derdin içinde ezildiğinizi ancak günlük hayattaki sorumluluklarınız yüzünden kendinizle ilgilenemediğinizi anlatır. Dertleriniz o kadar yoğundur ki bu dertleri işe, ilişkilerinize, evinize kadar taşırsınız. Ancak kartın mesajı şudur ki, kişi yüzmüş yüzmüş kuyruğuna gelmiştir. Hayat size zorluklar verdi ancak henüz pes etme zamanı değil, bu acının karşılığının daha güzel ve hayat dolu olacağını unutmayın."
},


      new TarotCard
{
    Id = 45,
    Name = "Değnek Onlusu",
    ImagePath = "/images/tarot_cards/Ten_of_Wands.jpg",
    Description = "Son bir çaba, bitişe yaklaşma",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Değnek onlusu, kişi her şey bitti sanırken aslında daha bitmediğini hatırlatır bize. Bütün yollar kapalı gibi gelebilir, insanların baskısı sizi ezebilir, monoton hayatınızdan sıkılmış olabilirsiniz. Ancak bu kart size yüzdün yüzdün kuyruğuna geldin, der. Bir borcunuz, birine hasretiniz, akademik sorunlarınız varsa bunların üstüne son bir kez daha gitmeli ve yeniden denemelisiniz. İlahi sistem sorunlarınıza çare bulmaya geliyor."
},

     new TarotCard
{
    Id = 46,
    Name = "Değnek Prensi",
    ImagePath = "/images/tarot_cards/Page_of_Wands.jpg",
    Description = "Genç, deneme yanılma, hareketli",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Değnek prensi yaşça genç, ilk adımları atmayı seven, biraz deneme yanılma yoluyla ilerleyen bir kişi kartıdır. Bu karakterimiz genellikle planını kafasında tasarladıktan sonra deneye deneye ilerlemektedir. Çok şanslıdır, sporla ilgilenmeyi sever. Sürekli hareketlidir."
},
     new TarotCard
{
    Id = 47,
    Name = "Değnek Şövalyesi",
    ImagePath = "/images/tarot_cards/Knight_of_Wands.jpg",
    Description = "Tutkulu, azimli, fevri",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Değnek şövalyesi orta yaşlı bir erkek figürdür. Bu kişi tutkulu, azimli, tuttuğunu koparan biridir. Aşkının önüne tutku ve hırs geçerse istediği kişiyi elde etmek için her şeyi yapar. Fevri olabilir. Eğer bir şeyi istemezse asla yapmaz, ancak isterse de o yolda ona göre her şey doğrudur."
},
     new TarotCard
{
    Id = 48,
    Name = "Değnek Kraliçesi",
    ImagePath = "/images/tarot_cards/Queen_of_Wands.jpg",
    Description = "Güçlü, kendini ifade eden, meraklı",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Değnek kraliçesi tarottaki en güçlü kraliçedir. Tuttuğunu koparan, elindeki değneğini sallayıp her istediğini elde eden biridir. Bu kadın figür bir erkeğin altında ezilmekten hoşlanmaz, kendini her anlamda güçlü göstermeye çalışır. Bazen insanların hayatına karışabilir ve merak edebilir. Sürekli yedek planları vardır ve asla işini garantiye almadan durmaz."
},


      new TarotCard
{
    Id = 49,
    Name = "Değnek Kralı",
    ImagePath = "/images/tarot_cards/King_of_Wands.jpg",
    Description = "Plan yapmayı seven, keşfetmeye aşık",
    YesNoMeaning = false,
    Element = Element.Fire,
    AdditionalMeaning = "Değnek kralı plan yapmayı seven, yeni şeyleri keşfetmeye aşık biridir. Mutlaka her gün ayrı bir planı, öğrenecek farklı bir konusu vardır. Bu kişi sporla veya fiziksel güç gerektiren şeylerle uğraşmayı sever. Tamir, mühendislik gibi alanlarda yeteneklidir. Hayat planlarına partnerini eklemeyi sever."
},

       new TarotCard
{
    Id = 50,
    Name = "Kupa Ası",
    ImagePath = "/images/tarot_cards/Ace_of_Cups.jpg",
    Description = "Hayatınızda büyük değişiklikler ve yenilikler sizi bekliyor.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Yeni bir ilişki veya romantik bir adım yolda olabilir. Mevcut bir ilişkiniz varsa, romantik bir döneme veya evlilik teklifine hazırlıklı olun. İlişkiniz yoksa, ideal partneriniz yolda olabilir. Şans ve bereket de size doğru yola çıkmış olabilir."
},

new TarotCard
{
    Id = 51,
    Name = "Kupa İkilisi",
    ImagePath = "/images/tarot_cards/Two_of_Cups.jpg",
    Description = "Mükemmel bir uyum ve ruhsal bağlantıyı temsil eder.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "İki insanın fiziksel ve duygusal anlamda kusursuz bir uyum içinde olduğunu gösterir. Uzun zamandır ayrı olduğunuz bir kişiyle kavuşmayı veya özlediğiniz biriyle bir araya gelmeyi ifade eder. Hayalinizdeki kişiyle buluşmanız mümkün."
},

new TarotCard
{
    Id = 52,
    Name = "Kupa Üçlüsü",
    ImagePath = "/images/tarot_cards/Three_of_Cups.jpg",
    Description = "Kutlama, sosyalleşme ve mutluluğu temsil eder.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Çevrenizle bir araya geleceğiniz, yeni insanlarla tanışacağınız ve önemli bir haber üzerine kutlamalar yapacağınız bir döneme giriyorsunuz. Şans sizden yana ve hayatın sunduğu güzel şeyleri kabul etme zamanı geldi."
},

new TarotCard
{
    Id = 53,
    Name = "Kupa Dörtlüsü",
    ImagePath = "/images/tarot_cards/Four_of_Cups.jpg",
    Description = "Mevcut fırsatları ve kısmetleri reddetmeyi gösterir.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Hayat size birçok fırsat sunuyor olabilir, ancak siz bunları göz ardı ediyor veya geçmişteki bir duruma takılı kalıyorsunuz. Elinizdekilere bağımlı kalmak yerine, hayatın sunduğu yenilikleri kabul etmelisiniz."
},

new TarotCard
{
    Id = 54,
    Name = "Kupa Beşlisi",
    ImagePath = "/images/tarot_cards/Five_of_Cups.jpg",
    Description = "Geçmişte yaşanan acıların hala etkili olduğunu gösterir.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Karamsarlık içinde olabilir ve eski olaylara takılı kalmış olabilirsiniz. Ancak gelecekte sizi bekleyen güzellikleri görmek için geçmişi geride bırakmanız gerekiyor. Ayrıca, geçmişten dönecek biri sizi zehirlemek isteyebilir, bu yüzden yeniye yönelmelisiniz."
},

new TarotCard
{
    Id = 55,
    Name = "Kupa Altılısı",
    ImagePath = "/images/tarot_cards/Six_of_Cups.jpg",
    Description = "Geçmişten gelen nostaljik ilişkiler ve uzun süreli sadakati temsil eder.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Uzun zamandır beklediğiniz bir müjde gelebilir, hasta olan bir yakınınız iyileşebilir veya bir bebek haberi alabilirsiniz. Dengeli ve güzel haberlerin yolda olduğunu belirtir."
},

new TarotCard
{
    Id = 56,
    Name = "Kupa Yedilisi",
    ImagePath = "/images/tarot_cards/Seven_of_Cups.jpg",
    Description = "Karar verme güçlüğü ve kafanın karışıklığını temsil eder.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Seçim yaparken zorlanıyor ve hayatınızdaki durumları ayırt edemiyorsunuz. Hayalgücünüzü değil, mantığınızı kullanarak derin bir nefes almalı ve gerekirse birilerine danışmalısınız."
},

new TarotCard
{
    Id = 57,
    Name = "Kupa Sekizlisi",
    ImagePath = "/images/tarot_cards/Eight_of_Cups.jpg",
    Description = "İstenmeyen ayrılıkları ve zorunlu vedaları gösterir.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Bir yeri veya kişiyi istemeyerek bırakmış olabilirsiniz. Yeni başlangıçlar için eskiyi terk etmek önemlidir. Eğer bu kart bir başkası için çekildiyse, bu kişi geri dönme potansiyeline sahip olabilir."
},

new TarotCard
{
    Id = 58,
    Name = "Kupa Dokuzlusu",
    ImagePath = "/images/tarot_cards/Nine_of_Cups.jpg",
    Description = "Huzur ve özgüveni temsil eder.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Artık arkanıza yaslanabilir ve rahat bir nefes alabilirsiniz. İstediğiniz her şey gerçekleşecek ve emeklerinizin karşılığı alınacak. Yanlış yapanlar cezalarını çekecek ve siz huzuru bulacaksınız."
},

new TarotCard
{
    Id = 59,
    Name = "Kupa Onlusu",
    ImagePath = "/images/tarot_cards/Ten_of_Cups.jpg",
    Description = "Aşkın tamamlanmış halini temsil eder.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "İlişkinizde güven ve tamamlanma duygusu hakim olacaktır. Artık doğru kişiyi bulmuşsunuz ve ilişkiniz güçlü bir şekilde devam edecektir. Hane içine güven ve huzur getirecek bir dönemdesiniz."
},

new TarotCard
{
    Id = 60,
    Name = "Kupa Prensi",
    ImagePath = "/images/tarot_cards/Page_of_Cups.jpg",
    Description = "Duygusal ve dengesiz bir kişiyi temsil eder.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Aşkı anlamakta zorlanabilir ve duygularını kontrol etmekte güçlük çekebilir. Genellikle kumral veya sarışın, entelektüel bir kişi olup, okumayı, yazmayı sever ve partnerine romantik jestlerde bulunur."
},

new TarotCard
{
    Id = 61,
    Name = "Kupa Şövalyesi",
    ImagePath = "/images/tarot_cards/Knight_of_Cups.jpg",
    Description = "Beyaz atlı prens karakterini temsil eder.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Partnerinin duygularına önem verir, ilişkisini bir sonraki aşamaya taşımak için çabalar ve romantik hediyeler sunar. İlişkiyi sürdürebilmek için özen gösterir ve gurur yapmadan ilerler."
},

new TarotCard
{
    Id = 62,
    Name = "Kupa Kraliçesi",
    ImagePath = "/images/tarot_cards/Queen_of_Cups.jpg",
    Description = "Duygusal ve içedönük bir kadını temsil eder.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Duygularını genellikle göstermekte zorlanır, ancak karşı tarafa derin bir aşk hisseder. Nazlı, kibar ve duygusal bir kişidir; hislerini nadiren açsa da, hissettirir."
},

new TarotCard
{
    Id = 63,
    Name = "Kupa Kralı",
    ImagePath = "/images/tarot_cards/King_of_Cups.jpg",
    Description = "Güçlü ve sevgi dolu bir karakterdir.",
    YesNoMeaning = false,
    Element = Element.Water,
    AdditionalMeaning = "Sevgisini sunmaktan çekinmez ancak bazen manipülatif olabilir. İş hayatında başarılıdır ve hayatının merkezine sevdiği kişiyi alır. Dengesiz ve kendi alanına düşkün olabilir, ancak sevgi dolu ve destekleyici bir partnerdir."
},

      new TarotCard
{
    Id = 64,
    Name = "Kılıç Ası",
    ImagePath = "/images/tarot_cards/Ace_of_Swords.jpg",
    Description = "Hayatınızdaki hedeflerinize ulaşmak için net bir adım atmanız gerektiğini belirtir.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Şu anda zorlandığınız veya ertelediğiniz konulara odaklanmalısınız. Azimli olmalı ve küçük zorluklarda pes etmemelisiniz. Bu süreçte istikrarlı olursanız, istediğiniz şey kalıcı ve güzel bir şekilde gerçekleşecektir."
},

new TarotCard
{
    Id = 65,
    Name = "Kılıç İkilisi",
    ImagePath = "/images/tarot_cards/Two_of_Swords.jpg",
    Description = "Karar verememe ve kendinizi sıkışmış hissetme durumunu temsil eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Bu kart, elinizin kolunuzun bağlı olduğu hissini gösterir. Ancak, her zaman bir çözüm yolu vardır. Kendinizi bir odaya kilitlemek yerine o odanın kapısını açmalı ve karar vermelisiniz."
},

new TarotCard
{
    Id = 66,
    Name = "Kılıç Üçlüsü",
    ImagePath = "/images/tarot_cards/Three_of_Swords.jpg",
    Description = "Kalp kırıklığı ve kişisel sırların ifşa edilmesini temsil eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Kişisel sırlarınızı ve ilişkinizi kimseye anlatmamalısınız. Üçüncü kişilerin etkisi veya toksik fikirler kalp kırıklığına yol açabilir. Sırlarınızı koruyarak ve partnerinizin davranışlarına dikkat ederek bu durumu önlemelisiniz."
},

new TarotCard
{
    Id = 67,
    Name = "Kılıç Dörtlüsü",
    ImagePath = "/images/tarot_cards/Four_of_Swords.jpg",
    Description = "Dinlenme ve yenilenme ihtiyacını temsil eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Yoğun mücadeleler sonrası dinlenme vakti gelmiştir. Biraz mola vermeli ve düşüncelerinizi toparlamalısınız. Bu kart ayrıca tatil yapma ve iş temposundan uzaklaşma ihtimalini de gösterir."
},

new TarotCard
{
    Id = 68,
    Name = "Kılıç Beşlisi",
    ImagePath = "/images/tarot_cards/Five_of_Swords.jpg",
    Description = "Geçmişteki savaşların ve karmaşanın sona ermesini gösterir.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Geçmişte yaşadığınız zor durumları hala atlatamamış olabilirsiniz. Ancak artık geçmişi geride bırakma ve geleceğe odaklanma zamanı geldi. Karmaşık düşüncelerden uzaklaşarak hayatınızda yeni bir sayfa açmalısınız."
},

new TarotCard
{
    Id = 69,
    Name = "Kılıç Altılısı",
    ImagePath = "/images/tarot_cards/Six_of_Swords.jpg",
    Description = "Bir yerden başka bir yere gitmek ve kendinizi korumak anlamına gelir.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Kendinize zarar veren bir şeyden veya kişiden uzaklaşma zamanıdır. Yeni bir başlangıç yapmak ve kendinizi korumak için bu adımı atmalısınız. Korksanız bile, bu değişim sizin için faydalı olacaktır."
},

new TarotCard
{
    Id = 70,
    Name = "Kılıç Yedilisi",
    ImagePath = "/images/tarot_cards/Seven_of_Swords.jpg",
    Description = "Sinsilik ve zararlı insanlardan kaçınma gereğini gösterir.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Çevrenizdeki zararlı insanlardan, dedikodulardan ve haksızlıklardan uzak durmalısınız. İşinizi doğru yapmalı ve sırlarınızı dikkatlice saklamalısınız. Ketum olmalı ve ilahi adalete güvenmelisiniz."
},

new TarotCard
{
    Id = 71,
    Name = "Kılıç Sekizlisi",
    ImagePath = "/images/tarot_cards/Eight_of_Swords.jpg",
    Description = "Engeller ve gönüllü esareti temsil eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Yaşadığınız sorunlar ve engeller, aslında sizin içsel durumunuzun yansıması olabilir. Gözlerinizi açmalı ve esaretin anahtarını bulmalısınız. Bu engellerin üstesinden gelmek için bilinçli bir çaba göstermelisiniz."
},

new TarotCard
{
    Id = 72,
    Name = "Kılıç Dokuzlusu",
    ImagePath = "/images/tarot_cards/Nine_of_Swords.jpg",
    Description = "Karamsarlık ve sosyal bağlantılardan kaçınmayı ifade eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Kendinizi karamsar ve yalnız hissedebilirsiniz. Sosyal bağlarınız zayıflamış olabilir. Bu süreçte kendinizi zorlayarak dışarı çıkmalı ve iyi düşüncelere yönelmelisiniz. Durumun geçici olduğunu unutmamalısınız."
},

new TarotCard
{
    Id = 73,
    Name = "Kılıç Onlusu",
    ImagePath = "/images/tarot_cards/Ten_of_Swords.jpg",
    Description = "Bir dönemin sonunu ve yeni bir başlangıcı temsil eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Bir ilişki, iş veya durumun artık sona erdiğini gösterir. Bu bitiş, hayatınızda temiz bir sayfa açma fırsatı sunar. Artık daha ferah ve temiz bir başlangıç yapabilirsiniz."
},

new TarotCard
{
    Id = 74,
    Name = "Kılıç Prensi",
    ImagePath = "/images/tarot_cards/Page_of_Swords.jpg",
    Description = "Heyecanlı ve fevri bir kişiyi temsil eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Bu karakter heyecanlı, fevri ve kendine güveni az olabilir. Kendisine sürekli sorular sorar ve sorumluluklarını üstlenir. Sevgisini gizler ve yara almaktan korkar."
},

new TarotCard
{
    Id = 75,
    Name = "Kılıç Şövalyesi",
    ImagePath = "/images/tarot_cards/Knight_of_Swords.jpg",
    Description = "Fevri ve ani hareketleri olan bir kişiyi temsil eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Bu karakter dengesiz adımları ve ani iniş çıkışları ile tanınır. Kafasına göre hareket eder ve korkusuzdur. Maço ve sert bir yanı vardır, hayattaki ani değişimlerin temsilcisidir."
},

new TarotCard
{
    Id = 76,
    Name = "Kılıç Kraliçesi",
    ImagePath = "/images/tarot_cards/Queen_of_Swords.jpg",
    Description = "Soğuk ve sınırları olan bir kadını temsil eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Bu karakter soğuk, mantıklı ve sınırları olan bir kadındır. Kalbine girmek zor olabilir ve sürekli tetikte bekler. Hayatını ve ilişkilerini kontrol etmeye çalışır."
},

new TarotCard
{
    Id = 77,
    Name = "Kılıç Kralı",
    ImagePath = "/images/tarot_cards/King_of_Swords.jpg",
    Description = "Soğuk ve mantıklı bir erkeği temsil eder.",
    YesNoMeaning = false,
    Element = Element.Air,
    AdditionalMeaning = "Bu karakter soğuk, sınırları olan ve mantığı kalbine ağır basan bir erkektir. Kalbine girmek zor olabilir ve sürekli tetikte bekler. Hayatını ve ilişkilerini kontrol eder, gururludur ve geri kafalı olabilir."
},


        };

        public static List<TarotCard> GetAllCards() => _cards;
    }
}

