/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50719
Source Host           : localhost:3306
Source Database       : jldb

Target Server Type    : MYSQL
Target Server Version : 50719
File Encoding         : 65001

Date: 2017-11-10 17:54:13
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `article`
-- ----------------------------
DROP TABLE IF EXISTS `article`;
CREATE TABLE `article` (
  `AutoId` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(256) NOT NULL,
  `Content` text,
  `Picture` varchar(512) DEFAULT NULL,
  `AddTime` datetime DEFAULT NULL,
  `Tags` varchar(256) DEFAULT NULL,
  `PageViews` int(11) DEFAULT NULL,
  `SortIndex` int(11) DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of article
-- ----------------------------
INSERT INTO `article` VALUES ('1', '水分在冬季对皮肤', '<p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\"><strong style=\"margin: 0px; padding: 0px;\">&nbsp; &nbsp; &nbsp; 1、补水</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　水分在冬季对皮肤的意义不言而喻，它是保持肌肤健康丰腴、富有弹性的重要因素，因此，要选用富含保湿因子及多种营养成分的保湿护肤品。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　<strong style=\"margin: 0px; padding: 0px;\">　2、去角质</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　冬季外界气温降低、空气更干燥时，皮肤的毛孔常处在收缩状态，表皮老化角质不易完全脱落。表皮太厚就会影响护肤品的吸收，护肤品无法起到滋润保养的作用。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　<strong style=\"margin: 0px; padding: 0px;\">　3、防晒</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　即使在日光照晒并不严重的冬天，紫外线也一样无处不在，因此冬季一定要用防晒或是抗紫线成分的美容产品。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　<strong style=\"margin: 0px; padding: 0px;\">4、滋润</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　冬季洗脸次数不要太多，早晚两次就可以了。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　<strong style=\"margin: 0px; padding: 0px;\">5、衣物</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">冬季皮肤特别容易干燥、瘙痒、起皮。其实，这不光是因为气候的关系，还由于身体和衣服产生的静电刺激皮肤所致。因此，像这样的天气，我们还是尽量选用纯棉的衣服。如果觉得纯棉的衣服太松了，穿在身上不保暖，也可选用加莱卡棉的。这样，既不易产生静电，又起到塑身保暖的效果。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　<strong style=\"margin: 0px; padding: 0px;\">6、食疗</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　吃些富含维生素A的食物，因为人体缺乏维生素A时，皮肤也会变得干燥。因此，推荐大家吃黄豆猪蹄汤。浓浓的，粘粘的，黄豆猪蹄汤是补充维生素E和胶原蛋白的，一星期吃一次，干燥的皮肤会得到改善。还有白木薏仁汤、红枣枸杞汤这些都是美容清肠排毒的好东西。</p><p><br/></p>', null, '2017-11-08 00:00:00', null, '0', '0', '0');
INSERT INTO `article` VALUES ('2', '水分在冬季对皮肤', '<p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\"><strong style=\"margin: 0px; padding: 0px;\">&nbsp; &nbsp; &nbsp; 1、补水</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　水分在冬季对皮肤的意义不言而喻，它是保持肌肤健康丰腴、富有弹性的重要因素，因此，要选用富含保湿因子及多种营养成分的保湿护肤品。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　<strong style=\"margin: 0px; padding: 0px;\">　2、去角质</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　冬季外界气温降低、空气更干燥时，皮肤的毛孔常处在收缩状态，表皮老化角质不易完全脱落。表皮太厚就会影响护肤品的吸收，护肤品无法起到滋润保养的作用。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　<strong style=\"margin: 0px; padding: 0px;\">　3、防晒</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　即使在日光照晒并不严重的冬天，紫外线也一样无处不在，因此冬季一定要用防晒或是抗紫线成分的美容产品。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　<strong style=\"margin: 0px; padding: 0px;\">4、滋润</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　冬季洗脸次数不要太多，早晚两次就可以了。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　<strong style=\"margin: 0px; padding: 0px;\">5、衣物</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">冬季皮肤特别容易干燥、瘙痒、起皮。其实，这不光是因为气候的关系，还由于身体和衣服产生的静电刺激皮肤所致。因此，像这样的天气，我们还是尽量选用纯棉的衣服。如果觉得纯棉的衣服太松了，穿在身上不保暖，也可选用加莱卡棉的。这样，既不易产生静电，又起到塑身保暖的效果。</p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　<strong style=\"margin: 0px; padding: 0px;\">6、食疗</strong></p><p style=\"margin-top: 20px; margin-bottom: 0px; white-space: normal; padding: 0px; line-height: 28px; font-family: &quot;Microsoft Yahei&quot;; color: rgb(51, 51, 51); background-color: rgb(255, 255, 255);\">　　吃些富含维生素A的食物，因为人体缺乏维生素A时，皮肤也会变得干燥。因此，推荐大家吃黄豆猪蹄汤。浓浓的，粘粘的，黄豆猪蹄汤是补充维生素E和胶原蛋白的，一星期吃一次，干燥的皮肤会得到改善。还有白木薏仁汤、红枣枸杞汤这些都是美容清肠排毒的好东西。</p><p><br/></p>', null, '2017-11-08 00:00:00', null, '0', '0', '0');
INSERT INTO `article` VALUES ('3', '20岁开始的护肤的步骤？', '<p>谢邀。今年20 等着进21</p><p><br/></p><p>我下面从基本护肤顺序+简单推荐，到基本原理解释及注意事项来做一个介绍吧。我是混合偏油皮肤，之前各种爆痘、痘印，后来全好了。现在不用底妆（粉底液）直接化眼睛眉毛都不会有什么问题。<span style=\"text-decoration:underline;\"><strong>20岁的皮肤已经开始流失水分和胶原，不认真护肤一定会在25+开始有细纹哦~</strong></span></p><p><br/></p><p>之前在知乎上打过一个帖子，是有关补水面膜的，但是我却从各个方向都做了回答，迄今收获了1300多个赞同。之前很多人让我推荐护肤产品，同时提到价格，这个帖子我就把价格也加上。本人不卖东西不做代购，有个自有专利的搞美容仪器研发的公司。以下：</p><p><br/></p><p>先从晚上说：顺序是：清洁→补水→面膜→精华→保湿</p><p>1. 清洁</p><p>清洁、防晒、补水是20多岁的小女生护肤最关键的三个部分。先说清洁。80%的爆痘，其实都是因为清洁不到位。导致皮肤毛孔堵塞，所以不通透。</p><p><br/></p><p>不论上妆与否，我一般使用<strong>森田药妆的卸妆棉（48片约60元）</strong>先擦一遍。森田是个做补水的很神奇的牌子，它的卸妆湿巾里也添加了玻尿酸。所以基本卸的时候也在补水，而且外面的脏东西卸掉了之后，上面膜或者精华的时候才不会再把脏吸收进去。（不上妆你也会用隔离和防晒，这些都是简单清洗会洗不掉的，必须使用化学卸妆。）</p><p><br/><br/>作者：李逸凡Yifan<br/>链接：https://www.zhihu.com/question/26439282/answer/56931301<br/>来源：知乎<br/>著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。</p><p><br/></p>', '~/Images/Products/20171108/20171108152343!.png', '2017-11-08 00:00:00', null, '0', '0', '0');
INSERT INTO `article` VALUES ('4', '如何延缓衰老？', '<p>作者：杜審言<br/>链接：https://www.zhihu.com/question/20806377/answer/256772488<br/>来源：知乎<br/>著作权归作者所有，转载请联系作者获得授权。<br/><br/></p><p>延缓衰老，跟思想层面息息相关，一个年轻的头脑，才能保持精力充沛，生机勃勃的身体。</p><p><br/></p><p>1，<strong>伏久者飞必高，开先者谢独早</strong>。做事慢慢的来，年轻的时候，不要过于透支自己身体，精力和精神。越来越多的年轻人过劳死，猝死，发病之前，觉得精力非常旺盛，有使不完的劲，效率很高，头脑清醒，其实都是虚的，这件就跟挑灯火，火光霎的一下变光亮了，是一样的道路，无法持久的。</p><p>看看战场上厮杀的将军，肚子被刺破，肠子都流出来了，他没注意到，专心致志的戮力杀敌，丝毫不受影响，哪是因为全身的精气神都被用到他的刀剑上了，对于身上的伤口，身体没有多余的元气，来拉响警报。结果下面收拾战场的时候，发现受伤了，马上感觉到痛，支撑不住，一会就去世了。</p><p>身心透支过度，是万病之源，早早把精神劲透支出来，必然早衰多病。你在异常忙碌，高度关注于某件事情，身体会自动忽略其他的受损修复，来全力以赴的配合和支持你。所以你感受不到疾病，并代表健康，很有可能已经病入脊髓。</p><p>我们在忙一个重要项目的时候，一个月不休息，昏天黑地，终于忙完了。想要好好的放松下，舒一口气，很有可能疲劳感，重大疾病平时不显露，在你休息的几天里彻底暴发了。</p><p>人的精神不是靠工作，事务刺激出来的，而是自身五脏六腑，精气神，元气，精血充满后，自然流露出来的。薪水高，就很用力的扛着，早晚要出问题。</p><p>有过煲汤经验的都知道，一直开着大火，猛烈的烧汤两个小时，跟用文火慢慢的熬，小沸，小火炖，完全是两个决然不同的味道。文火能释放出食材的全部品味，而且非常的鲜美，人生亦是如此，慢些很快就沸腾的，不一定是好事。</p><p>上次看到一个新闻，中国的秃顶人数里面，年轻人占了半壁江山，值得警惕。</p><p><br/></p><p>千万不要经常去挑生命的灯火，你挑得越亮，越容易衰老得病，二十几岁的年纪，四五十岁的器官。要学会慢慢的添油。没事去山中静着几天，过一过世外桃源的生活，摘摘果子，不要一根弦绷得那么紧。</p><p><br/></p><p>2，<strong>凡事不宜过于用力，过于用情，慧极必伤，情深不寿。</strong>为人处世态度，性格上，做一位谦谦君子，温润如玉，沉稳而含蓄，坚毅而不张扬。</p><p>人太聪明，什么事都想到非常的全面，仔细，看得过深，过透。会这个也避讳，哪个也担心，操心小细节没有做好，就会像诸葛亮一样，耗尽心血而死，英年早逝。这不是一个好的习惯，做到大事明白，小事糊涂就好。</p><p>谈一场恋爱，分手了，就跟生了三个月的大病似的，整个人都虚弱无力，茶饭不思。自古情深者，没有一位长寿的，看看梁山伯祝英台。并不是一点感情都不投入，适度就好。而且太沉迷和执着的感情，也是最不容易长久的。</p><p>情到深处，必然生死相随，独自一人，黯然销魂，迎着西风凋碧树，独上高楼，望尽天涯路，成为唯一的精神支柱，不利于生命的延长，看看林黛玉。</p><p><br/></p><p><strong>3，人生做到自强不息即可，不必过于英气逼人，人前风光。</strong></p><p><br/></p>', '~/Images/Articles/20171108/20171108153716!.jpg', '2017-11-08 00:00:00', null, '0', '0', '0');
INSERT INTO `article` VALUES ('5', '有哪些让你相见恨晚的化妆品和护肤品？', '<p>作者：慕容七<br/>链接：https://www.zhihu.com/question/22390958/answer/21233456<br/>来源：知乎<br/>著作权归作者所有，转载请联系作者获得授权。<br/><br/></p><p>我将我朋友们的总结与大家分享，这是我们几百个人将近两年时间的沉淀，综合使用感、副作用、价格等多方面因素。请感激q群“学术派护肤”中群友<strong><a data-hash=\"5a58a3872f40bfc12fa1d71f83ef242b\" href=\"//www.zhihu.com/people/5a58a3872f40bfc12fa1d71f83ef242b\" class=\"member_mention\" data-editable=\"true\" data-title=\"@林月如\" data-tip=\"p$b$5a58a3872f40bfc12fa1d71f83ef242b\" data-hovercard=\"p$b$5a58a3872f40bfc12fa1d71f83ef242b\">@林月如</a></strong>和<a data-hash=\"d22e4c16d78723cca3c6f8bb8e3d325e\" href=\"//www.zhihu.com/people/d22e4c16d78723cca3c6f8bb8e3d325e\" class=\"member_mention\" data-editable=\"true\" data-title=\"@黄恬甜\" data-tip=\"p$b$d22e4c16d78723cca3c6f8bb8e3d325e\" data-hovercard=\"p$b$d22e4c16d78723cca3c6f8bb8e3d325e\">@黄恬甜</a> ，主要是她们整理，我只负责搬运： &nbsp;<br/><strong>一。洁面</strong><br/><span style=\"text-decoration:underline;\">1.旁氏米粹</span><br/>各大超市均有销售，特点是便宜大碗。<br/>技术部分来看该产品，是椰油酰甘氨酸盐的结晶法+增稠法生产，选料优秀，对皮肤刺激小，冲水后肤感爽而不紧绷，长期使用不会对皮肤造成负面影响。<br/><span style=\"text-decoration:underline;\">2.清妃柔白洗面奶</span><br/>上海家化的产品，值得信赖。N年前被称作五星级的洗面奶，国货中最早出名的氨基酸洗面奶。<br/><span style=\"text-decoration:underline;\">3.Estee Lauder红石榴洁面</span><br/>皂基复配甘氨酸，洗后不干不紧绷。<br/><strong>二。补水</strong><br/><span style=\"text-decoration:underline;\">1.Caudalie/欧缇丽葡萄籽保湿活性喷雾</span><br/>评价是“喷头最好的喷雾产品。”<br/><span style=\"text-decoration:underline;\">2.曼秀雷敦肌研极润保湿化妆水</span><br/>平价易得，保湿效果明显<br/>三。保湿<br/><span style=\"text-decoration:underline;\">1.Trilogy 100%有机玫瑰果油</span><br/>滋润性强，气味友好，不腻不粘，亲肤性好，调理角质。<br/><span style=\"text-decoration:underline;\">2.高丝kose 密集保湿精华液</span><br/><span style=\"text-decoration:underline;\">3.兰皙欧润源养颜精华露</span><br/>（以上两款群友推荐，我个人没法给予评价）<br/><span style=\"text-decoration:underline;\">4.颐莲透明质酸焕彩魔方安瓶精华</span><br/>成分简单，补水保湿。但是因为保湿效果过好，可能超过皮肤需要，有可能导致角质过度水合闷痘。<br/><span style=\"text-decoration:underline;\">5.CeraVe Moisturizing Cream CeraVe治疗性保湿霜</span><br/>适合干皮、过敏皮。<br/>滋养、修复和维护皮肤防护屏障, 并使其保持湿润。<br/><span style=\"text-decoration:underline;\">6.Trilogy 玫瑰果油强效保湿滋润膏/万能膏</span><br/>挡风啊。<br/>四。抗氧化<br/><span style=\"text-decoration:underline;\">1.Arcona Magic White Ice魔力白冰补水精华</span><br/>日间保湿抗氧化乳液。有控油效果，适合油皮用在夏季，其它类型皮肤叠加保湿即可。<br/><span style=\"text-decoration:underline;\">2.dr.Alkaitis 有机舒缓水漾精华</span><br/>便宜大碗的抗氧化精华，推荐油皮使用，适合夏季<br/>五。美白<br/><span style=\"text-decoration:underline;\">1.Olay旗舰 玉兰油Pro-X纯白方精华液</span><br/></p><p>美白、抗氧化、抗衰老、抗炎。</p><p>高浓度烟酰胺的代表产品，如果不是搓泥，那就一定是极好的。</p><p><br/>有很多人对烟酰胺不耐受，皮肤发红，需要注意一下。美白、淡化新生痘印效果显著。<br/><span style=\"text-decoration:underline;\">2.Elings Orange 20% Vitamin C L-Ascorbic Acid Serum</span><br/></p><p>白天用，抗氧化+增强防晒效果；晚间用，淡斑美白抗衰老。</p><p>20%VC浓度，薄皮敏感皮慎用。</p><p>比较油腻，建议秋冬使用。<br/><span style=\"text-decoration:underline;\">3.THE BODY SHOP美体小铺VC 28天美白精华胶囊</span><br/>VC胶囊，每次一到两粒，配合PHA精华，价格便宜啊，不错的东西<br/><strong>六。防晒（这部分靠后只是因为整理顺序，在护肤中，防晒是重中之重，本部分还要感谢<a data-hash=\"5a58a3872f40bfc12fa1d71f83ef242b\" href=\"//www.zhihu.com/people/5a58a3872f40bfc12fa1d71f83ef242b\" class=\"member_mention\" data-editable=\"true\" data-title=\"@林月如\" data-tip=\"p$b$5a58a3872f40bfc12fa1d71f83ef242b\" data-hovercard=\"p$b$5a58a3872f40bfc12fa1d71f83ef242b\">@林月如</a> 辛苦搜集的各种产品的博文介绍，在此拜谢） </strong><br/><span style=\"text-decoration:underline;\">1.Elta MD UV Shield SPF45无油防晒乳</span><br/></p><p>这款是物理+化学的防晒，不用特别卸妆，普通洗面奶清洁即可。不防水。</p><p>适合夏季，日常使用。详细介绍参见<a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_66f1d01d01019tcm.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">EltaMD UV SHIELD BROAD-SPECTRUM SPF 45_巫的幻想<em class=\"icon-external\"></em></a><br/><span style=\"text-decoration:underline;\">2.SHISEIDO ANESSA资生堂安耐晒金瓶超强防水防晒霜SPF50 PA++++</span><br/></p><p>适合户外上山下海的一款防水抗汗的防晒霜，SPF50+ PA++++</p><p>一定要摇匀后使用</p><p><br/><span style=\"text-decoration:underline;\">3.嘉娜宝ALLIE极致防水药用防晒霜SPF50 &nbsp;PA++++</span><br/></p><p>防水抗汗，媲美安耐晒金瓶</p><p><br/>涂改液剂型，摇匀后使用。博文介绍<a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_691c4c82010169qb.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">清爽防晒——ALLIE 防晒霜 三种颜色对比<em class=\"icon-external\"></em></a><br/><span style=\"text-decoration:underline;\">4.索菲娜芯美颜日间防晒乳 SPF50 PA++++</span><br/></p><p>清爽、轻薄，不油腻不粘不厚重不闷，也不干。</p><p>不油腻不粘不厚重不闷，也不干不油腻不粘不厚重不闷，也不干不油腻不粘不厚重不闷，也不干估计最大的问题就是一个字——贵<br/>博文介绍<a href=\"//link.zhihu.com/?target=http%3A//space.yoka.com/blog/2111230/8171834.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">小花小花夸拉拉——SOFINA日间倍护防晒乳<em class=\"icon-external\"></em></a><br/></p><p><a href=\"//link.zhihu.com/?target=http%3A//my.pclady.com.cn/d/1881320.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">我的小花一家――sofina_太平洋女性网<em class=\"icon-external\"></em></a></p><p><a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_5351d4e501015mhg.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">sofina小花防晒……=-=_shine日<em class=\"icon-external\"></em></a><br/><span style=\"text-decoration:underline;\">5.Sofina Jenne day protector SPF50 + PA+++苏菲娜透美颜日间倍护防护乳</span><br/></p><p>JENNE算是物美价廉了~~</p><p>摇摇乐，物理+化学<br/>博文介绍<a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_6c5941ab0101izfi.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">好用到飞起来的Sofina Jenne防晒啊！！<em class=\"icon-external\"></em></a><br/></p><p><a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_495abdf30102egx9.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">我真想说这是我这辈子最爱的防晒！<em class=\"icon-external\"></em></a><a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_7c4d4cfd0101anzg.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">小清新也可以穿上蕾丝——Sofina Jenne小结（卸妆液、化妆水、凝乳、防晒）<em class=\"icon-external\"></em></a></p><p><a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_64eee5f30101ayya.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">SOFINA jenne SPF50防晒<em class=\"icon-external\"></em></a><br/><span style=\"text-decoration:underline;\">6. SkinMedica 全天侯矿物防晒霜SPF30+</span><br/></p><p>7.3%二氧化钛+3.4%氧化锌配方，纯物理防晒，记得使用之前先摇匀，否则容易水油分离。</p><p>这款无油清爽不油腻不泛白，防水需卸妆。</p><p>群友说这款当做妆前很好很好，你们参考一下吧，博文介绍<a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_6d0c277a0101ch9q.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">与防晒孽缘终结者——SkinMedica全天候矿物物理防晒霜SPF30+_小尘埃<em class=\"icon-external\"></em></a><br/></p><p><a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_66f1d01d010159n9.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">Skinmedica Environmental Defense Sunscreen SPF30+_巫的幻想<em class=\"icon-external\"></em></a></p><p><a href=\"//link.zhihu.com/?target=http%3A//blog.163.com/xdye_1980/blog/static/83165792201285102921672/\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">SkinMedica Daily Physical Defense SPF30+物理防晒<em class=\"icon-external\"></em></a><br/><span style=\"text-decoration:underline;\">7.瑞士Ultrasun高效抗敏防晒霜spf30</span><br/></p><p>不油腻；防水；适合敏感肤质；化学+物理防晒</p><p>不泛白不油腻</p><p>更适合秋冬用~<br/><span style=\"text-decoration:underline;\">8.SkinCeuticals杜克 Physical UV Defense SPF 30全物理性防晒霜SPF30</span><br/>5%二氧化钛+4%氧化锌，纯物理防晒，不防水无需卸妆，更适合敏感皮肤，不会拔干。<br/><span style=\"text-decoration:underline;\">9.Za姬芮 新能真皙美白防晒霜SPF30 PA+++</span><br/></p><p>防水抗汗，略泛白，拔干，适合夏季或油皮的一款防晒霜。</p><p>需卸妆。</p><p>专柜、屈臣氏有售，博文介绍<a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_651de88c0100y970.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">适合油皮的防晒 ZA新能真皙美白防晒霜_flora7_新浪博客<em class=\"icon-external\"></em></a><br/></p><p><a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_6f953eb90100usw7.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">好用又便宜的ZA新能真皙美白防晒霜SPF30+/PA+++_Sandy_新浪博客<em class=\"icon-external\"></em></a></p><p><a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_5ffe72d80100zzs7.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">ZA防晒霜SPF30PA+++_小丸子<em class=\"icon-external\"></em></a><br/><span style=\"text-decoration:underline;\">10.碧柔清爽防晒乳液SPF50 PA+++</span><br/></p><p>沃尔玛、屈臣氏有售，请前往试用</p><p>适合油皮，非常干爽</p><p>不建议油皮、混油以外肤质使用。</p><p>适合日常使用<br/><span style=\"text-decoration:underline;\">11.碧柔水活防晒保湿凝蜜SPF30+PA+++</span><br/></p><p>沃尔玛、屈臣氏有售，请前往试用</p><p>较为水润，清爽</p><p>适合日常使用，无需卸妆，博文介绍<a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_651de88c010138xl.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">碧柔水活防晒保湿凝蜜_flora7_新浪博客<em class=\"icon-external\"></em></a><br/><span style=\"text-decoration:underline;\">12.Cetaphil/丝塔芙控油保湿防晒乳SPF30</span><br/>化学防晒，不油腻不泛白，群友强力推荐<br/><span style=\"text-decoration:underline;\">13.美加净细嫩柔白防晒乳SPF30\r\nPA+++</span><br/></p><p>上海家化出品，便宜大碗的身体防晒，使劲撸，使劲补擦各种不心疼。</p><p>含天来施M和S，化学防晒成分，防护波段齐全。不泛白。</p><p>缺点：香味浓重。瓶口设计不易掌握用量。不防水。博文介绍<a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_651de88c01015clt.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">那些值得买了又买的便宜防晒_flora7_新浪博客<em class=\"icon-external\"></em></a></p><p><a href=\"//link.zhihu.com/?target=http%3A//blog.sina.com.cn/s/blog_6a524b100100yyh2.html\" class=\" wrap external\" target=\"_blank\" rel=\"nofollow noreferrer\">美加净SPF30PA+++细嫩柔白防晒乳(▼ω▼ )便宜大碗,亚拉那一卡<em class=\"icon-external\"></em></a></p><p><br/><span style=\"text-decoration:underline;\">14.Coppertone水宝宝无泪无香水嫩防晒霜乳液SPF50</span><br/></p><p>优点：便宜大碗，防水能力很棒，适合游泳时抹身体，日常就算了哈。</p><p>缺点：高浓度的氧化锌配方导致白的跟死人一样，上脸就是艺妓，所以建议用于身体。比较难推匀。<br/><span style=\"text-decoration:underline;\">15.Coppertone\r\n水宝宝连续喷雾SPF50</span><br/></p><p>优点：游泳时使用方便，成膜快速，防水好。</p><p>缺点：非常不经用，用后看起来皮肤油亮，含防晒成分阿伏苯宗会染黄衣服。<br/><br/><br/><strong>七。润唇膏</strong><br/><span style=\"text-decoration:underline;\">1.Blistex Lip Medex 即时修复润唇膏</span><br/>修复滋润保湿，便宜大碗<br/><span style=\"text-decoration:underline;\">2.新西兰 康维他纯天然蜂胶防晒润唇膏SPF30+VE</span><br/><a data-hash=\"d22e4c16d78723cca3c6f8bb8e3d325e\" href=\"//www.zhihu.com/people/d22e4c16d78723cca3c6f8bb8e3d325e\" class=\"member_mention\" data-editable=\"true\" data-title=\"@黄恬甜\" data-tip=\"p$b$d22e4c16d78723cca3c6f8bb8e3d325e\" data-hovercard=\"p$b$d22e4c16d78723cca3c6f8bb8e3d325e\">@黄恬甜</a> 力荐，比篮罐好，也比篮罐贵 <br/><span style=\"text-decoration:underline;\">3.Blistex碧唇医药特效修护润唇膏</span><br/></p><p>桃群友用了之后强烈推荐，可以淡化唇纹！比篮罐好用！</p><p><span style=\"text-decoration:underline;\">4.资生堂MOILIP药用口角炎护唇/润唇膏</span></p><p>日本cosme唇部护理部门2008,2009第一名（蝉联）<br/></p><p><strong>八。身体护理</strong></p><p><span style=\"text-decoration:underline;\">1.美国Aveeno\r\n天然燕麦强效修复护手霜</span></p><p><a data-hash=\"d22e4c16d78723cca3c6f8bb8e3d325e\" href=\"//www.zhihu.com/people/d22e4c16d78723cca3c6f8bb8e3d325e\" class=\"member_mention\" data-editable=\"true\" data-title=\"@黄恬甜\" data-tip=\"p$b$d22e4c16d78723cca3c6f8bb8e3d325e\" data-hovercard=\"p$b$d22e4c16d78723cca3c6f8bb8e3d325e\">@黄恬甜</a> 语“便宜大碗的AVEENO啊~~无香不油腻大碗~”</p><p><span style=\"text-decoration:underline;\">2.隆力奇蛇油膏</span></p><p>尼玛超市卖1块2的蛇油膏当做护手霜这种穷逼干的事情我会说吗？</p><p>嫌塑料袋装不方便携带的，请自己灌到名牌的空瓶里，尼玛立刻高端大气上档次了有木有！</p><p>护手霜的奥义就是没事就抹、有时间就抹。<br/></p><p><span style=\"text-decoration:underline;\">3.玉兰油7重功效润肤乳</span></p><p>烟酰胺（VB3）是宝洁的强项，几乎所有宝洁的产品里都能看见这个美白、修复成分，本品中VB3排名第三，便宜大碗的美白身体乳。<br/></p><p><span style=\"text-decoration:underline;\">4.ALPHA HYDROX SILKWRAP BODY LOTION果酸去角质保湿身体乳</span></p><p>12%的果酸（乳酸）含量，光滑肌肤且保湿，冬季用起来很舒服，不建议每天使用。香味不够友好哈，AH家一向如此。</p><p>膏体比较稠，需要花点时间按摩吸收。最好找店主要压泵头，否则挤压出来还是比较费劲的。<br/></p><p><span style=\"text-decoration:underline;\">5.宝拉珍选 2%水杨酸身体乳液</span></p><p><br/>2%水杨酸身体乳，和楼上的果酸身体乳一样，都可以对付后背长的痘痘，同样是去角质的身体乳，光滑肌肤</p><p><br/></p>', '~/Images/Articles/20171108/20171108154818!.jpg', '2017-11-08 00:00:00', null, '0', '0', '0');
INSERT INTO `article` VALUES ('6', '目前化妆品、护肤品中最安全的防腐剂是哪种？', '<p>1、高端和宣传植物护肤好像没啥联系，在防腐剂使用方面。<br/>2、标识无添加防腐剂的产品通常是用多元醇、馨鲜酮、辛酰羟肟酸、甘油辛酸酯（类）还有 <span data-reactroot=\"\" class=\"UserLink\"></span></p><p><a class=\"UserLink-link\" data-za-detail-view-element_name=\"User\" target=\"_blank\" href=\"/people/33b2b62b871c1dabf464665de993ceb4\"><!-- react-text: 5 -->@<!-- /react-text --><!-- react-text: 6 -->青城与峨眉<!-- /react-text --></a></p><p><!-- react-empty: 7 --></p><p>提到的天然植物、 <span data-reactroot=\"\" class=\"UserLink\"><p><a class=\"UserLink-link\" data-za-detail-view-element_name=\"User\" target=\"_blank\" href=\"/people/92ba1e6baa41585425bbb3e3ca3c839f\"><!-- react-text: 5 -->@<!-- /react-text --><!-- react-text: 6 -->代利<!-- /react-text --></a></p><p><!-- react-empty: 7 --></p></span>提到的发酵类的 等等，不在化妆品卫生规范的防腐剂表格中。<br/>3、能达到防腐功效而且能稳定、温和的防腐体系才是配方师追求的吧。</p><p></p><p><br/><br/>作者：李沐风<br/>链接：https://www.zhihu.com/question/34459480/answer/60003036<br/>来源：知乎<br/>著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。</p><p><br/></p>', '~/Images/Articles/20171108/20171108164633!.gif', '2017-11-08 00:00:00', null, '0', '0', '0');
INSERT INTO `article` VALUES ('7', '资深护肤专家推荐：双十一值得选购有机护肤产品', '<p><br/></p><p style=\"margin-top: 0px; margin-bottom: 0px; padding: 0px 0px 13px; box-sizing: border-box; font-family: simsun; white-space: normal; background-color: rgb(255, 255, 255);\">有机护肤代表了植物与天然，原料出于天然或受到有机农产认证，不是转基因产品，不含石化原料、矿物油、矽胶、杀虫剂、色素、合成香精、动物性原料，依照一定规格制造，过程不得受污染并尊重生态环境健康标准。由于不含化学成分添加剂，有机护肤相比市面上大多数产品而言更为安全，尤其是换季时分，容易敏感的肌肤更能深深体会到这一点。</p><p style=\"margin-top: 0px; margin-bottom: 0px; padding: 0px 0px 13px; box-sizing: border-box; font-family: simsun; white-space: normal; background-color: rgb(255, 255, 255);\">　　有着十多年护肤经验、资深有机护肤专家曾表示，“很多人都知道物理防晒和化学防晒的区别，却不明白物理(天然)护肤与化学护肤的区别，纯天然的有机护肤产品会逐步调节肌肤呈现更健康和稳定的状态。”</p><p style=\"margin-top: 0px; margin-bottom: 0px; padding: 0px 0px 13px; box-sizing: border-box; font-family: simsun; white-space: normal; background-color: rgb(255, 255, 255);\">　　了解有机护肤的好处，那么哪些有机护肤品牌值得入手呢?双十一又有哪些品牌促销力度最大呢?小编对此作了一番功课：以往众人熟知的有机品牌如欧舒丹、茱莉蔻、阿芙精油等双十一仍然有不少重磅的满减活动，值得一提的是作为英国老牌的有机护肤品牌Neal&#39;s Yard Remedies(NYR)，虽然不像法国的欧舒丹、澳洲的茱莉蔻那样为人熟知，却也凭借着康复利面霜、乳香面霜、优质的精油产品俘获了一批成分党和有机护肤人群的喜爱。今年天猫旗舰店的双十一活动力度惊人，不少博主和护肤达人都成为了他们家的粉丝。</p><p><br/></p>', '~/Images/Articles/20171108/20171108175937!.jpg', '2017-11-08 00:00:00', null, '0', '0', '0');
INSERT INTO `article` VALUES ('8', '一个万亿级市场正在爆发', '<p>11</p>', '~/Images/Articles/20171109/20171109110508!.gif', '2017-11-09 00:00:00', null, '0', '0', '1');

-- ----------------------------
-- Table structure for `debug`
-- ----------------------------
DROP TABLE IF EXISTS `debug`;
CREATE TABLE `debug` (
  `AutoId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(128) NOT NULL,
  `Value` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB AUTO_INCREMENT=453 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of debug
-- ----------------------------
INSERT INTO `debug` VALUES ('46', 'filter', '');
INSERT INTO `debug` VALUES ('47', 'filter', ' name like concat(\'%\',’,\'%\')  ');
INSERT INTO `debug` VALUES ('48', 'filter', ' name like concat(\'%\',’,\'%\')  ');
INSERT INTO `debug` VALUES ('49', 'wherefilter', ' where  name like concat(\'%\',’,\'%\')  ');
INSERT INTO `debug` VALUES ('50', 'andfilter', ' and  name like concat(\'%\',’,\'%\')  ');
INSERT INTO `debug` VALUES ('51', 'filter', ' name like concat(\'%\',’,\'%\')  ');
INSERT INTO `debug` VALUES ('52', 'wherefilter', ' where  name like concat(\'%\',’,\'%\')  ');
INSERT INTO `debug` VALUES ('53', 'andfilter', ' and  name like concat(\'%\',’,\'%\')  ');
INSERT INTO `debug` VALUES ('54', 'filter', ' name like \'%’%\')  ');
INSERT INTO `debug` VALUES ('55', 'wherefilter', ' where  name like \'%’%\')  ');
INSERT INTO `debug` VALUES ('56', 'andfilter', ' and  name like \'%’%\')  ');
INSERT INTO `debug` VALUES ('57', 'filter', ' name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('58', 'wherefilter', ' where  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('59', 'andfilter', ' and  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('60', 'filter', ' name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('61', 'wherefilter', ' where  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('62', 'andfilter', ' and  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('63', 'filter', ' name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('64', 'wherefilter', ' where  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('65', 'andfilter', ' and  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('66', 'filter', ' name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('67', 'wherefilter', ' where  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('68', 'andfilter', ' and  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('69', 'filter', ' name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('70', 'wherefilter', ' where  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('71', 'andfilter', ' and  name like \'%’%\'  ');
INSERT INTO `debug` VALUES ('72', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('73', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('74', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('75', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('76', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('77', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('78', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('79', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('80', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('81', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('82', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('83', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('84', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('85', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('86', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('87', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('88', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('89', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('90', 'orderby', '');
INSERT INTO `debug` VALUES ('91', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('92', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('93', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('94', 'orderby', '');
INSERT INTO `debug` VALUES ('95', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('96', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('97', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('98', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('99', 'orderby', '');
INSERT INTO `debug` VALUES ('100', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('101', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%‘%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('102', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('103', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('104', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('105', 'orderby', '');
INSERT INTO `debug` VALUES ('106', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('107', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%‘%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('108', 'strsql', null);
INSERT INTO `debug` VALUES ('109', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('110', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('111', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('112', 'orderby', '');
INSERT INTO `debug` VALUES ('113', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('114', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%‘%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('115', 'fields', '*');
INSERT INTO `debug` VALUES ('116', 'strsql', null);
INSERT INTO `debug` VALUES ('117', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('118', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('119', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('120', 'orderby', '');
INSERT INTO `debug` VALUES ('121', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('122', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%‘%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('123', 'fields', '*');
INSERT INTO `debug` VALUES ('124', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('125', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('126', 'startId', null);
INSERT INTO `debug` VALUES ('127', 'andFilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('128', 'strsql', null);
INSERT INTO `debug` VALUES ('129', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('130', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('131', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('132', 'orderby', '');
INSERT INTO `debug` VALUES ('133', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('134', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%‘%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('135', 'fields', '*');
INSERT INTO `debug` VALUES ('136', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('137', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('138', 'startId', '0');
INSERT INTO `debug` VALUES ('139', 'andFilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('140', 'strsql', 'select * from Franchisee where AutoId >=0  and  name like \'%‘%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('141', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('142', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('143', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('144', 'orderby', '');
INSERT INTO `debug` VALUES ('145', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('146', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%‘%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('147', 'fields', '*');
INSERT INTO `debug` VALUES ('148', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('149', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('150', 'startId', '0');
INSERT INTO `debug` VALUES ('151', 'andFilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('152', 'strsql', 'select * from Franchisee where AutoId >=0  and  name like \'%‘%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('153', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('154', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('155', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('156', 'orderby', '');
INSERT INTO `debug` VALUES ('157', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('158', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%‘%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('159', 'fields', '*');
INSERT INTO `debug` VALUES ('160', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('161', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('162', 'startId', '0');
INSERT INTO `debug` VALUES ('163', 'andFilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('164', 'strsql', 'select * from Franchisee where AutoId >=0  and  name like \'%‘%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('165', 'filter', ' name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('166', 'wherefilter', ' where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('167', 'andfilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('168', 'orderby', '');
INSERT INTO `debug` VALUES ('169', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('170', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%‘%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('171', 'fields', '*');
INSERT INTO `debug` VALUES ('172', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('173', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('174', 'startId', '0');
INSERT INTO `debug` VALUES ('175', 'andFilter', ' and  name like \'%‘%\'  ');
INSERT INTO `debug` VALUES ('176', 'strsql', 'select * from Franchisee where AutoId >=0  and  name like \'%‘%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('177', 'filter', '');
INSERT INTO `debug` VALUES ('178', 'wherefilter', '');
INSERT INTO `debug` VALUES ('179', 'andfilter', '');
INSERT INTO `debug` VALUES ('180', 'orderby', '');
INSERT INTO `debug` VALUES ('181', 'strsqlcount', 'select count(*) into @total from Franchisee ');
INSERT INTO `debug` VALUES ('182', 'sqlTmp', 'select AutoId into @startid from Franchisee  order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('183', 'fields', '*');
INSERT INTO `debug` VALUES ('184', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('185', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('186', 'startId', '1');
INSERT INTO `debug` VALUES ('187', 'andFilter', '');
INSERT INTO `debug` VALUES ('188', 'strsql', 'select * from Franchisee where AutoId >=1  order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('189', 'filter', ' name like \'%\'\'%\'  ');
INSERT INTO `debug` VALUES ('190', 'wherefilter', ' where  name like \'%\'\'%\'  ');
INSERT INTO `debug` VALUES ('191', 'andfilter', ' and  name like \'%\'\'%\'  ');
INSERT INTO `debug` VALUES ('192', 'orderby', '');
INSERT INTO `debug` VALUES ('193', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%\'\'%\'  ');
INSERT INTO `debug` VALUES ('194', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%\'\'%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('195', 'fields', '*');
INSERT INTO `debug` VALUES ('196', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('197', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('198', 'startId', '1');
INSERT INTO `debug` VALUES ('199', 'andFilter', ' and  name like \'%\'\'%\'  ');
INSERT INTO `debug` VALUES ('200', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%\'\'%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('201', 'filter', ' name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('202', 'wherefilter', ' where  name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('203', 'andfilter', ' and  name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('204', 'orderby', '');
INSERT INTO `debug` VALUES ('205', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('206', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%\'\'\'\'\'\'%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('207', 'fields', '*');
INSERT INTO `debug` VALUES ('208', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('209', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('210', 'startId', '1');
INSERT INTO `debug` VALUES ('211', 'andFilter', ' and  name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('212', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%\'\'\'\'\'\'%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('213', 'filter', ' name like \'%\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('214', 'wherefilter', ' where  name like \'%\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('215', 'andfilter', ' and  name like \'%\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('216', 'orderby', '');
INSERT INTO `debug` VALUES ('217', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('218', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%\'\'\'\'%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('219', 'fields', '*');
INSERT INTO `debug` VALUES ('220', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('221', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('222', 'startId', '1');
INSERT INTO `debug` VALUES ('223', 'andFilter', ' and  name like \'%\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('224', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%\'\'\'\'%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('225', 'filter', ' name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('226', 'wherefilter', ' where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('227', 'andfilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('228', 'orderby', '');
INSERT INTO `debug` VALUES ('229', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('230', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%_%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('231', 'fields', '*');
INSERT INTO `debug` VALUES ('232', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('233', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('234', 'startId', '1');
INSERT INTO `debug` VALUES ('235', 'andFilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('236', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%_%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('237', 'filter', ' name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('238', 'wherefilter', ' where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('239', 'andfilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('240', 'orderby', '');
INSERT INTO `debug` VALUES ('241', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('242', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%_%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('243', 'fields', '*');
INSERT INTO `debug` VALUES ('244', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('245', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('246', 'startId', '1');
INSERT INTO `debug` VALUES ('247', 'andFilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('248', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%_%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('249', 'filter', ' name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('250', 'wherefilter', ' where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('251', 'andfilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('252', 'orderby', '');
INSERT INTO `debug` VALUES ('253', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('254', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%_%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('255', 'fields', '*');
INSERT INTO `debug` VALUES ('256', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('257', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('258', 'startId', '1');
INSERT INTO `debug` VALUES ('259', 'andFilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('260', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%_%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('261', 'filter', ' name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('262', 'wherefilter', ' where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('263', 'andfilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('264', 'orderby', '');
INSERT INTO `debug` VALUES ('265', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('266', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%_%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('267', 'fields', '*');
INSERT INTO `debug` VALUES ('268', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('269', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('270', 'startId', '1');
INSERT INTO `debug` VALUES ('271', 'andFilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('272', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%_%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('273', 'filter', ' name like \'%%%\'  ');
INSERT INTO `debug` VALUES ('274', 'wherefilter', ' where  name like \'%%%\'  ');
INSERT INTO `debug` VALUES ('275', 'andfilter', ' and  name like \'%%%\'  ');
INSERT INTO `debug` VALUES ('276', 'orderby', '');
INSERT INTO `debug` VALUES ('277', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%%%\'  ');
INSERT INTO `debug` VALUES ('278', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%%%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('279', 'fields', '*');
INSERT INTO `debug` VALUES ('280', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('281', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('282', 'startId', '1');
INSERT INTO `debug` VALUES ('283', 'andFilter', ' and  name like \'%%%\'  ');
INSERT INTO `debug` VALUES ('284', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%%%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('285', 'filter', ' name like \'%\\_%\'  ');
INSERT INTO `debug` VALUES ('286', 'wherefilter', ' where  name like \'%\\_%\'  ');
INSERT INTO `debug` VALUES ('287', 'andfilter', ' and  name like \'%\\_%\'  ');
INSERT INTO `debug` VALUES ('288', 'orderby', '');
INSERT INTO `debug` VALUES ('289', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%\\_%\'  ');
INSERT INTO `debug` VALUES ('290', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%\\_%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('291', 'fields', '*');
INSERT INTO `debug` VALUES ('292', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('293', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('294', 'startId', '1');
INSERT INTO `debug` VALUES ('295', 'andFilter', ' and  name like \'%\\_%\'  ');
INSERT INTO `debug` VALUES ('296', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%\\_%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('297', 'filter', ' name like \'%1 or 1=1 ;#%\'  ');
INSERT INTO `debug` VALUES ('298', 'wherefilter', ' where  name like \'%1 or 1=1 ;#%\'  ');
INSERT INTO `debug` VALUES ('299', 'andfilter', ' and  name like \'%1 or 1=1 ;#%\'  ');
INSERT INTO `debug` VALUES ('300', 'orderby', '');
INSERT INTO `debug` VALUES ('301', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%1 or 1=1 ;#%\'  ');
INSERT INTO `debug` VALUES ('302', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%1 or 1=1 ;#%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('303', 'fields', '*');
INSERT INTO `debug` VALUES ('304', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('305', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('306', 'startId', '1');
INSERT INTO `debug` VALUES ('307', 'andFilter', ' and  name like \'%1 or 1=1 ;#%\'  ');
INSERT INTO `debug` VALUES ('308', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%1 or 1=1 ;#%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('309', 'filter', ' name like \'%___***%\'  ');
INSERT INTO `debug` VALUES ('310', 'wherefilter', ' where  name like \'%___***%\'  ');
INSERT INTO `debug` VALUES ('311', 'andfilter', ' and  name like \'%___***%\'  ');
INSERT INTO `debug` VALUES ('312', 'orderby', '');
INSERT INTO `debug` VALUES ('313', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%___***%\'  ');
INSERT INTO `debug` VALUES ('314', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%___***%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('315', 'fields', '*');
INSERT INTO `debug` VALUES ('316', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('317', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('318', 'startId', '0');
INSERT INTO `debug` VALUES ('319', 'andFilter', ' and  name like \'%___***%\'  ');
INSERT INTO `debug` VALUES ('320', 'strsql', 'select * from Franchisee where AutoId >=0  and  name like \'%___***%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('321', 'filter', ' name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('322', 'wherefilter', ' where  name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('323', 'andfilter', ' and  name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('324', 'orderby', '');
INSERT INTO `debug` VALUES ('325', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('326', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%*%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('327', 'fields', '*');
INSERT INTO `debug` VALUES ('328', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('329', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('330', 'startId', '0');
INSERT INTO `debug` VALUES ('331', 'andFilter', ' and  name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('332', 'strsql', 'select * from Franchisee where AutoId >=0  and  name like \'%*%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('333', 'filter', ' name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('334', 'wherefilter', ' where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('335', 'andfilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('336', 'orderby', '');
INSERT INTO `debug` VALUES ('337', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('338', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%_%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('339', 'fields', '*');
INSERT INTO `debug` VALUES ('340', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('341', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('342', 'startId', '1');
INSERT INTO `debug` VALUES ('343', 'andFilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('344', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%_%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('345', 'filter', ' name like \'%&%\'  ');
INSERT INTO `debug` VALUES ('346', 'wherefilter', ' where  name like \'%&%\'  ');
INSERT INTO `debug` VALUES ('347', 'andfilter', ' and  name like \'%&%\'  ');
INSERT INTO `debug` VALUES ('348', 'orderby', '');
INSERT INTO `debug` VALUES ('349', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%&%\'  ');
INSERT INTO `debug` VALUES ('350', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%&%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('351', 'fields', '*');
INSERT INTO `debug` VALUES ('352', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('353', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('354', 'startId', '0');
INSERT INTO `debug` VALUES ('355', 'andFilter', ' and  name like \'%&%\'  ');
INSERT INTO `debug` VALUES ('356', 'strsql', 'select * from Franchisee where AutoId >=0  and  name like \'%&%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('357', 'filter', ' name like \'%#%\'  ');
INSERT INTO `debug` VALUES ('358', 'wherefilter', ' where  name like \'%#%\'  ');
INSERT INTO `debug` VALUES ('359', 'andfilter', ' and  name like \'%#%\'  ');
INSERT INTO `debug` VALUES ('360', 'orderby', '');
INSERT INTO `debug` VALUES ('361', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%#%\'  ');
INSERT INTO `debug` VALUES ('362', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%#%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('363', 'fields', '*');
INSERT INTO `debug` VALUES ('364', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('365', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('366', 'startId', '0');
INSERT INTO `debug` VALUES ('367', 'andFilter', ' and  name like \'%#%\'  ');
INSERT INTO `debug` VALUES ('368', 'strsql', 'select * from Franchisee where AutoId >=0  and  name like \'%#%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('369', 'filter', ' name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('370', 'wherefilter', ' where  name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('371', 'andfilter', ' and  name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('372', 'orderby', '');
INSERT INTO `debug` VALUES ('373', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('374', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%*%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('375', 'fields', '*');
INSERT INTO `debug` VALUES ('376', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('377', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('378', 'startId', '0');
INSERT INTO `debug` VALUES ('379', 'andFilter', ' and  name like \'%*%\'  ');
INSERT INTO `debug` VALUES ('380', 'strsql', 'select * from Franchisee where AutoId >=0  and  name like \'%*%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('381', 'filter', ' name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('382', 'wherefilter', ' where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('383', 'andfilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('384', 'orderby', '');
INSERT INTO `debug` VALUES ('385', 'strsqlcount', 'select count(*) into @total from Franchisee  where  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('386', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  name like \'%_%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('387', 'fields', '*');
INSERT INTO `debug` VALUES ('388', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('389', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('390', 'startId', '1');
INSERT INTO `debug` VALUES ('391', 'andFilter', ' and  name like \'%_%\'  ');
INSERT INTO `debug` VALUES ('392', 'strsql', 'select * from Franchisee where AutoId >=1  and  name like \'%_%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('393', 'filter', ' email like \'%\'\'%\'  and  name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('394', 'wherefilter', ' where  email like \'%\'\'%\'  and  name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('395', 'andfilter', ' and  email like \'%\'\'%\'  and  name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('396', 'orderby', '');
INSERT INTO `debug` VALUES ('397', 'strsqlcount', 'select count(*) into @total from Franchisee  where  email like \'%\'\'%\'  and  name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('398', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  email like \'%\'\'%\'  and  name like \'%\'\'\'\'\'\'%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('399', 'fields', '*');
INSERT INTO `debug` VALUES ('400', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('401', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('402', 'startId', '1');
INSERT INTO `debug` VALUES ('403', 'andFilter', ' and  email like \'%\'\'%\'  and  name like \'%\'\'\'\'\'\'%\'  ');
INSERT INTO `debug` VALUES ('404', 'strsql', 'select * from Franchisee where AutoId >=1  and  email like \'%\'\'%\'  and  name like \'%\'\'\'\'\'\'%\'   order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('405', 'filter', '');
INSERT INTO `debug` VALUES ('406', 'wherefilter', '');
INSERT INTO `debug` VALUES ('407', 'andfilter', '');
INSERT INTO `debug` VALUES ('408', 'orderby', '');
INSERT INTO `debug` VALUES ('409', 'strsqlcount', 'select count(*) into @total from Franchisee ');
INSERT INTO `debug` VALUES ('410', 'sqlTmp', 'select AutoId into @startid from Franchisee  order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('411', 'fields', '*');
INSERT INTO `debug` VALUES ('412', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('413', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('414', 'startId', '1');
INSERT INTO `debug` VALUES ('415', 'andFilter', '');
INSERT INTO `debug` VALUES ('416', 'strsql', 'select * from Franchisee where AutoId >=1  order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('417', 'filter', '');
INSERT INTO `debug` VALUES ('418', 'wherefilter', '');
INSERT INTO `debug` VALUES ('419', 'andfilter', '');
INSERT INTO `debug` VALUES ('420', 'orderby', '');
INSERT INTO `debug` VALUES ('421', 'strsqlcount', 'select count(*) into @total from Franchisee ');
INSERT INTO `debug` VALUES ('422', 'sqlTmp', 'select AutoId into @startid from Franchisee  order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('423', 'fields', '*');
INSERT INTO `debug` VALUES ('424', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('425', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('426', 'startId', '1');
INSERT INTO `debug` VALUES ('427', 'andFilter', '');
INSERT INTO `debug` VALUES ('428', 'strsql', 'select * from Franchisee where AutoId >=1  order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('429', 'filter', '');
INSERT INTO `debug` VALUES ('430', 'wherefilter', '');
INSERT INTO `debug` VALUES ('431', 'andfilter', '');
INSERT INTO `debug` VALUES ('432', 'orderby', '');
INSERT INTO `debug` VALUES ('433', 'strsqlcount', 'select count(*) into @total from Franchisee ');
INSERT INTO `debug` VALUES ('434', 'sqlTmp', 'select AutoId into @startid from Franchisee  order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('435', 'fields', '*');
INSERT INTO `debug` VALUES ('436', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('437', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('438', 'startId', '1');
INSERT INTO `debug` VALUES ('439', 'andFilter', '');
INSERT INTO `debug` VALUES ('440', 'strsql', 'select * from Franchisee where AutoId >=1  order by AutoId asc  limit 20');
INSERT INTO `debug` VALUES ('441', 'filter', ' email like \'%sfd%\'  ');
INSERT INTO `debug` VALUES ('442', 'wherefilter', ' where  email like \'%sfd%\'  ');
INSERT INTO `debug` VALUES ('443', 'andfilter', ' and  email like \'%sfd%\'  ');
INSERT INTO `debug` VALUES ('444', 'orderby', '');
INSERT INTO `debug` VALUES ('445', 'strsqlcount', 'select count(*) into @total from Franchisee  where  email like \'%sfd%\'  ');
INSERT INTO `debug` VALUES ('446', 'sqlTmp', 'select AutoId into @startid from Franchisee  where  email like \'%sfd%\'   order by AutoId asc limit 0,1');
INSERT INTO `debug` VALUES ('447', 'fields', '*');
INSERT INTO `debug` VALUES ('448', 'tablename', 'Franchisee');
INSERT INTO `debug` VALUES ('449', 'primarykey', 'AutoId');
INSERT INTO `debug` VALUES ('450', 'startId', '3');
INSERT INTO `debug` VALUES ('451', 'andFilter', ' and  email like \'%sfd%\'  ');
INSERT INTO `debug` VALUES ('452', 'strsql', 'select * from Franchisee where AutoId >=3  and  email like \'%sfd%\'   order by AutoId asc  limit 20');

-- ----------------------------
-- Table structure for `franchisee`
-- ----------------------------
DROP TABLE IF EXISTS `franchisee`;
CREATE TABLE `franchisee` (
  `AutoId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(256) NOT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `Weixin` varchar(128) DEFAULT NULL,
  `Phone` varchar(16) DEFAULT NULL,
  `Address` varchar(256) DEFAULT NULL,
  `Remark` varchar(2048) DEFAULT NULL,
  `ApplyTime` datetime DEFAULT NULL,
  `ProcessTime` datetime DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of franchisee
-- ----------------------------
INSERT INTO `franchisee` VALUES ('1', '张三', null, null, null, null, null, '2017-11-09 15:15:50', '2017-11-09 15:15:50', '1');
INSERT INTO `franchisee` VALUES ('2', '李四', null, null, null, null, null, '2017-11-09 17:39:46', '2017-11-09 17:39:46', '1');
INSERT INTO `franchisee` VALUES ('3', '王五', 'sfsfdsf', '123123123', '213123', null, null, '2017-11-10 16:32:25', '2017-11-10 16:32:25', '1');

-- ----------------------------
-- Table structure for `jl_user`
-- ----------------------------
DROP TABLE IF EXISTS `jl_user`;
CREATE TABLE `jl_user` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(128) DEFAULT NULL,
  `Cellphone` varchar(16) DEFAULT NULL,
  `IsCellphoneConfirmed` bit(1) DEFAULT b'0',
  `Email` varchar(128) DEFAULT NULL,
  `IsEmailConfirmed` bit(1) DEFAULT b'0',
  `RealName` varchar(128) DEFAULT NULL,
  `NickName` varchar(128) DEFAULT NULL,
  `Telephone` varchar(255) DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  `Gender` char(1) DEFAULT NULL,
  `QQ` varchar(16) DEFAULT NULL,
  `Address` varchar(256) DEFAULT NULL,
  `AddTime` datetime DEFAULT NULL,
  `RegUrl` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of jl_user
-- ----------------------------
INSERT INTO `jl_user` VALUES ('5', 'admin', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('6', 'user001', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('7', 'user100', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('8', 'user101', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('9', 'user102', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('10', 'user103', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('11', 'user104', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('12', 'user105', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('13', 'user106', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('14', 'user107', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('15', 'user108', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('16', 'user109', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('17', 'user110', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('18', 'user111', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('19', 'user112', null, '', null, '', null, null, null, null, null, null, null, null, null);

-- ----------------------------
-- Table structure for `material`
-- ----------------------------
DROP TABLE IF EXISTS `material`;
CREATE TABLE `material` (
  `AutoId` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(64) NOT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `Picture` varchar(256) DEFAULT NULL,
  `FileName` varchar(256) DEFAULT NULL,
  `MaterialType` char(1) DEFAULT NULL,
  `PageViews` int(11) DEFAULT NULL COMMENT '浏览量/下载量',
  `SortIndex` int(11) DEFAULT '0',
  `Status` char(1) DEFAULT 'N',
  `Url` varchar(512) DEFAULT NULL,
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of material
-- ----------------------------

-- ----------------------------
-- Table structure for `member`
-- ----------------------------
DROP TABLE IF EXISTS `member`;
CREATE TABLE `member` (
  `AutoId` int(11) NOT NULL AUTO_INCREMENT,
  `NickName` varchar(64) DEFAULT NULL,
  `RealName` varchar(32) DEFAULT NULL,
  `Description` varchar(1024) DEFAULT NULL,
  `Phone` varchar(16) DEFAULT NULL,
  `Weixin` varchar(16) DEFAULT NULL,
  `QQ` varchar(16) DEFAULT NULL,
  `Email` varchar(64) DEFAULT NULL,
  `Address` varchar(128) DEFAULT NULL,
  `JoinTime` datetime DEFAULT NULL,
  `Picture` varchar(128) DEFAULT NULL,
  `Words` varchar(1024) DEFAULT NULL,
  `SortIndex` int(11) DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of member
-- ----------------------------

-- ----------------------------
-- Table structure for `product`
-- ----------------------------
DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `AutoId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(128) DEFAULT NULL,
  `Alias` varchar(64) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `Picture` varchar(1024) DEFAULT NULL,
  `RetailPrice` float DEFAULT NULL,
  `MarketPrice` float DEFAULT NULL,
  `PageViews` int(11) DEFAULT NULL,
  `SortIndex` int(11) DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of product
-- ----------------------------
INSERT INTO `product` VALUES ('1', '111', null, '<p>1111111</p>', '~/Images/Products/20171108/20171108124456!.jpg', '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('2', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('3', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('4', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('5', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('6', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('7', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('8', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('9', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('10', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('11', null, null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('12', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('13', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('14', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('15', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('16', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('17', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('18', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('19', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('20', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('21', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('22', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('23', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('24', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, '<p>针对不同的肌肤问题，量身定制不同功效的面膜。让肌肤得到精细化的滋养和呵护，令肌肤恢复到“原始”之美，才能令女性真正由内而外获得返璞归真的美丽世界</p>', null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('25', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', '高分子补水面膜', '<p>针对不同的肌肤问题，量身定制不同功效的面膜。让肌肤得到精细化的滋养和呵护，令肌肤恢复到“原始”之美，才能令女性真正由内而外获得返璞归真的美丽世界</p>', '~/Images/Products/20171106/20171106174307!.jpg', '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('26', '岁月无忌高分子补水面膜玻尿酸补水锁水淡化细纹提亮肤色蚕丝面膜', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('27', '222', null, null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('28', '岁月无忌玻尿酸原液 补水 锁水 保湿 精华液 胶原蛋白 滋养', null, '<p><span style=\"color: rgb(108, 108, 108); font-family: tahoma, arial, &quot;Hiragino Sans GB&quot;, 宋体, sans-serif; font-size: 12px; background-color: rgb(255, 255, 255);\">储水功能，湿润滋养，皮肤更显饱满、丰盈、有弹性。</span></p>', '~/Images/Products/20171107/20171107102215!.jpg', '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('29', '美可莱面膜 DNA 蚕丝面膜抑制色斑 紧致祛黄', 'DNA', '<p><span style=\"color: rgb(108, 108, 108); font-family: tahoma, arial, &quot;Hiragino Sans GB&quot;, 宋体, sans-serif; font-size: 12px; background-color: rgb(255, 255, 255);\">巴黎创美殿堂级美容科研中心倾力打造全新白金级奢宠DNA臻白无瑕面膜。革新性独有的sirtrin酵素能为肌肤提供水润丰盈源动力，增强肌肤抗疫力；</span></p>', null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('30', '岁月无忌面膜活性肽瓷肤润亮面膜补水保湿紧致提亮肤色收细毛孔', '活性肽', '<p><span style=\"color: rgb(108, 108, 108); font-family: tahoma, arial, &quot;Hiragino Sans GB&quot;, 宋体, sans-serif; font-size: 12px; background-color: rgb(255, 255, 255);\">独家活性肽成分与多种天然草本精华，配合其独特的低温保湿水原蛋白给予肌肤清新舒适的感觉，促进面膜中的精萃活性成份最大程度上被肌肤有效吸收。强化提升两颊及下颚线条，紧致提拉肌肤，提亮肤色、收细毛孔，肌肤丰盈紧实宛如新生。</span></p>', '~/Images/Products/20171107/20171107162907!.jpg', '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('31', '111', '1', '<p>111<br/></p>', null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('32', '111', '1', null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('33', '111', '1', null, null, '0', '0', '0', '0', '0');
INSERT INTO `product` VALUES ('34', null, null, null, '~/Images/Products/20171108/20171108142520!.jpg', '0', '0', '0', '0', '0');

-- ----------------------------
-- Table structure for `productcategory`
-- ----------------------------
DROP TABLE IF EXISTS `productcategory`;
CREATE TABLE `productcategory` (
  `AutoId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(32) DEFAULT NULL,
  `Alias` varchar(32) DEFAULT NULL,
  `Picture` varchar(128) DEFAULT NULL,
  `Path` varchar(64) DEFAULT NULL,
  `Depth` int(11) DEFAULT NULL,
  `ParentId` int(11) DEFAULT NULL,
  `PageViews` int(11) DEFAULT NULL,
  `SortIndex` int(11) DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of productcategory
-- ----------------------------
INSERT INTO `productcategory` VALUES ('32', '面膜系列', '面膜', null, null, '0', '0', '0', '1', '1');
INSERT INTO `productcategory` VALUES ('33', 'xx', 'x', null, null, '0', '0', '0', '777', '1');

-- ----------------------------
-- Table structure for `productcategorylink`
-- ----------------------------
DROP TABLE IF EXISTS `productcategorylink`;
CREATE TABLE `productcategorylink` (
  `ProductId` int(11) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  PRIMARY KEY (`ProductId`,`CategoryId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of productcategorylink
-- ----------------------------
INSERT INTO `productcategorylink` VALUES ('22', '32');
INSERT INTO `productcategorylink` VALUES ('26', '22');
INSERT INTO `productcategorylink` VALUES ('27', '22');
INSERT INTO `productcategorylink` VALUES ('28', '32');
INSERT INTO `productcategorylink` VALUES ('29', '33');
INSERT INTO `productcategorylink` VALUES ('30', '33');

-- ----------------------------
-- Table structure for `webpages_membership`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_membership`;
CREATE TABLE `webpages_membership` (
  `UserId` int(11) NOT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `ConfirmationToken` varchar(128) CHARACTER SET utf8 DEFAULT NULL,
  `IsConfirmed` bit(1) DEFAULT b'0',
  `LastPasswordFailureDate` datetime DEFAULT NULL,
  `PasswordFailuresSinceLastSuccess` int(11) NOT NULL DEFAULT '0',
  `Password` varchar(128) CHARACTER SET utf8 NOT NULL,
  `PasswordChangedDate` datetime DEFAULT NULL,
  `PasswordSalt` varchar(128) CHARACTER SET utf8 NOT NULL,
  `PasswordVerificationToken` varchar(128) CHARACTER SET utf8 DEFAULT NULL,
  `PasswordVerificationTokenExpirationDate` datetime DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_membership
-- ----------------------------
INSERT INTO `webpages_membership` VALUES ('3', '2017-10-16 14:52:27', null, '', '2017-10-16 16:01:21', '1', 'T5C6AQv0yOwQ4/l+WDjgXrWMTLqXYkDF8MREuPP09d7UxavG97d4Qr6v1n92HYpu', '2017-10-16 14:52:27', '', null, null);
INSERT INTO `webpages_membership` VALUES ('4', '2017-10-25 17:12:34', null, '', null, '0', '+tEWIrAJhsvyIJAprLNHn1TehUDzCVmI8QyrCzU32yYwpFXlppnd1qagbhlH/Xc9', '2017-10-25 17:12:34', '', null, null);
INSERT INTO `webpages_membership` VALUES ('5', '2017-10-26 11:33:32', null, '', null, '0', 'AIiMAgS8JIP9xwspsNiMplfsA+kqnVXe03qXTEo0zlMrhLI3NHvlIH3L9YcwLpgjzQ==', '2017-10-26 11:33:32', '', null, null);
INSERT INTO `webpages_membership` VALUES ('6', '2017-10-26 11:33:58', null, '', null, '0', 'AJuMPyC6/rtRfywr4D8yfat6Re9hfOWqfK8YmMkmuoI/wnk/2scMQddj7fXNXxjxxw==', '2017-10-26 11:33:58', '', null, null);
INSERT INTO `webpages_membership` VALUES ('7', '2017-10-26 11:36:39', null, '', null, '0', 'AG7IhymaG3ly63T3igEL9aW0uN4iBtr1joVmZB8NCdeYi3TYk+Lc0r1JjItr0risWg==', '2017-10-26 11:36:39', '', null, null);
INSERT INTO `webpages_membership` VALUES ('8', '2017-10-26 11:41:37', null, '', null, '0', 'AB0se2smcie9H3vC41oxBwvTBdHrD8ENDdy5cbShOrp79J+cg3/wA5OC1kBIvboGfg==', '2017-10-26 11:41:37', '', null, null);
INSERT INTO `webpages_membership` VALUES ('9', '2017-10-26 11:49:03', null, '', null, '0', 'AHo9A+irXpuUGDDLM68jxuVByC2DLCGG2ktb04JJ0rYXBSr2tZ81p9Td8eyvUDyu+Q==', '2017-10-26 11:49:03', '', null, null);
INSERT INTO `webpages_membership` VALUES ('10', '2017-10-26 11:49:57', null, '', null, '0', 'AEJPjH+LyPLXZmMCRHH7t/ZJnSAciuq6clr0t2hjIGj4l86cq68xbAuLQFj9cLNYHw==', '2017-10-26 11:49:57', '', null, null);
INSERT INTO `webpages_membership` VALUES ('11', '2017-10-26 12:03:06', null, '', null, '0', 'AAK9KAQ23n1pCU5aOJSVsYFzcvnvVSD4k6m2kxATgX2MsiK7qA3oO84Gfx2RijrujQ==', '2017-10-26 12:03:06', '', null, null);
INSERT INTO `webpages_membership` VALUES ('12', '2017-10-26 13:56:24', null, '', null, '0', 'ADcvg8xXmD9+B05KZvDBn1Xwl2Z48ghWQeUTRG2fi11LpLHc56RqpywXgXY/R5/NBw==', '2017-10-26 13:56:24', '', null, null);
INSERT INTO `webpages_membership` VALUES ('13', '2017-10-26 13:56:32', null, '', null, '0', 'ADaI+RkuyZa11Wzpbjz5Kf2JZJuya1z45ARb49b/VMVeJxigGjwl6h3JfczBhJLDKQ==', '2017-10-26 13:56:32', '', null, null);
INSERT INTO `webpages_membership` VALUES ('14', '2017-10-26 13:56:34', null, '', null, '0', 'AOMzKFKme/7BYP9kXC9/6ZxGWQo9T2NSvsFZKTIIfB4vkPYFRoxk3dsqowgkGI/gDw==', '2017-10-26 13:56:34', '', null, null);
INSERT INTO `webpages_membership` VALUES ('15', '2017-10-26 13:56:35', null, '', null, '0', 'AHrW+i150+9Yq0CMdzYhYc9d7+cFYwWH3/jQVcbzf43gmTYopQDEUnpnYGPXLr0plA==', '2017-10-26 13:56:35', '', null, null);
INSERT INTO `webpages_membership` VALUES ('16', '2017-10-26 14:03:28', null, '', null, '0', 'AL6iUJ1cOw5aUjZz0gxOiW2rtNFe6Qc7FCxvgCZEjgvUqoz2/n6RvBhxhhQ+sSLoWw==', '2017-10-26 14:03:28', '', null, null);
INSERT INTO `webpages_membership` VALUES ('17', '2017-10-26 14:10:30', null, '', null, '0', 'AGf+3r7Sb+f7WMu20uIlHWkR9RF7AxjiJyjj+AuWGhMh/X7NoVCzTQdOFttvzJFsuQ==', '2017-10-26 14:10:30', '', null, null);
INSERT INTO `webpages_membership` VALUES ('18', '2017-10-26 15:19:52', 'X2Q5UAHw9v_RaefazKe0iA2', '', null, '0', 'ALmJKcdoow6RIqYWjFMh5DsVSb3FgON98rb/5WtXV3sQyuANhXavyAkmPEoT45Exfw==', '2017-10-26 15:19:52', '', null, null);
INSERT INTO `webpages_membership` VALUES ('19', '2017-10-30 14:50:48', 'iIXPj8yGxBv3frjr-PG8aw2', '', null, '0', 'AJdI2+hBHQsl1EPifwfUK9es14mu4Mvnd1loP2lG+SuIbwIcyHvn6bhrUXvLsw3NXQ==', '2017-10-30 14:50:48', '', null, null);

-- ----------------------------
-- Table structure for `webpages_oauthmembership`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_oauthmembership`;
CREATE TABLE `webpages_oauthmembership` (
  `Provider` varchar(30) CHARACTER SET utf8 NOT NULL,
  `ProviderUserId` varchar(100) CHARACTER SET utf8 NOT NULL,
  `UserId` int(11) NOT NULL,
  PRIMARY KEY (`Provider`,`ProviderUserId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_oauthmembership
-- ----------------------------

-- ----------------------------
-- Table structure for `webpages_oauthtoken`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_oauthtoken`;
CREATE TABLE `webpages_oauthtoken` (
  `Token` varchar(100) CHARACTER SET utf8 NOT NULL,
  `Secret` varchar(100) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`Token`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_oauthtoken
-- ----------------------------

-- ----------------------------
-- Table structure for `webpages_roles`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_roles`;
CREATE TABLE `webpages_roles` (
  `RoleId` int(11) NOT NULL AUTO_INCREMENT,
  `RoleName` varchar(256) NOT NULL,
  PRIMARY KEY (`RoleId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_roles
-- ----------------------------
INSERT INTO `webpages_roles` VALUES ('1', 'admin');
INSERT INTO `webpages_roles` VALUES ('2', 'user');

-- ----------------------------
-- Table structure for `webpages_usersinroles`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_usersinroles`;
CREATE TABLE `webpages_usersinroles` (
  `UserId` int(11) NOT NULL,
  `RoleId` int(11) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `fk_RoleId` (`RoleId`),
  CONSTRAINT `fk_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `webpages_roles` (`RoleId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_usersinroles
-- ----------------------------
INSERT INTO `webpages_usersinroles` VALUES ('5', '1');
INSERT INTO `webpages_usersinroles` VALUES ('6', '2');
INSERT INTO `webpages_usersinroles` VALUES ('7', '2');
INSERT INTO `webpages_usersinroles` VALUES ('8', '2');
INSERT INTO `webpages_usersinroles` VALUES ('9', '2');
INSERT INTO `webpages_usersinroles` VALUES ('10', '2');
INSERT INTO `webpages_usersinroles` VALUES ('11', '2');
INSERT INTO `webpages_usersinroles` VALUES ('12', '2');
INSERT INTO `webpages_usersinroles` VALUES ('13', '2');
INSERT INTO `webpages_usersinroles` VALUES ('14', '2');
INSERT INTO `webpages_usersinroles` VALUES ('15', '2');
INSERT INTO `webpages_usersinroles` VALUES ('16', '2');
INSERT INTO `webpages_usersinroles` VALUES ('17', '2');
INSERT INTO `webpages_usersinroles` VALUES ('18', '2');
INSERT INTO `webpages_usersinroles` VALUES ('19', '2');

-- ----------------------------
-- Procedure structure for `procPageQuery`
-- ----------------------------
DROP PROCEDURE IF EXISTS `procPageQuery`;
DELIMITER ;;
CREATE DEFINER=`chenye`@`%` PROCEDURE `procPageQuery`(in page int,
 in pagesize int,
 in fields varchar(1000),
 in tablename varchar(512),
 in filter varchar(512) ,in orderby varchar(128),in primarykey varchar(32),out total int)
    COMMENT '分页存储过程'
BEGIN
 if pagesize<=1 then
  set pagesize=20;
 end if;
 if page < 1 then
  set page = 1;
 end if;
 
 set filter=ifnull(filter,'');
insert into debug(name,value) values('filter',filter);
 
 if(length(trim(filter))>0) then
  set @whereFilter=concat(' where ',filter);
	set @andFilter=concat(' and ',filter);
 else
	set @whereFilter='';
	set @andFilter='';
 end if;

insert into debug(name,value) values('wherefilter',@whereFilter);
insert into debug(name,value) values('andfilter',@andFilter);

 set orderby=ifnull(orderby,'');
 if(length(trim(orderby))>0) then
  set orderby=concat(' , ',orderby);
 end if;
insert into debug(name,value) values('orderby',orderby);

 set @strsqlcount=concat('select count(*) into @total from ',tablename,' ',@whereFilter);
insert into debug(name,value) values('strsqlcount',@strsqlcount);

 prepare stmtsqlcount from @strsqlcount;
 execute stmtsqlcount;
 deallocate prepare stmtsqlcount;

 set total=@total;

 set @sqlTmp=concat('select ',primarykey		
    ,' into @startid'
		,' from '
		,tablename,' '
		,@whereFilter,
		' order by '
		,primarykey
		,' asc limit '
		,(page-1)*pagesize,',1'); 
insert into debug(name,value) values('sqlTmp',@sqlTmp);

 prepare stmsql from @sqlTmp;
 execute stmsql ;
 deallocate prepare stmsql;

 set @startid=ifnull(@startid,0);

 set @strsql = concat('select '
		,`fields`
		,' from '
		,tablename
		,' where '
		,primarykey
		,' >='
		,@startId 
		,' ',@andFilter
		,' order by '
		,primarykey
		,' asc '
		,orderby
		,' limit ',pagesize);
insert into debug(name,value) values('fields',`fields`);
insert into debug(name,value) values('tablename',tablename);
insert into debug(name,value) values('primarykey',primarykey);
insert into debug(name,value) values('startId',@startId );
insert into debug(name,value) values('andFilter',@andFilter);
insert into debug(name,value) values('strsql',@strsql);

 prepare stmtsql from @strsql;
 execute stmtsql;
 deallocate prepare stmtsql;

END
;;
DELIMITER ;
