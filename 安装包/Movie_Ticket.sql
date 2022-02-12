create database Movie_ticket;

use Movie_ticket;

create table region#省市表
(province_code varchar(3),#省编号
province varchar(8) not null,#省级名称
city_code varchar(6) not null unique,#市编号
city varchar(6)not null unique,#市级名称
primary key(city_code)
);


create table Movie#电影
(Mno varchar(10) primary key not null unique,#电影编号
Mname varchar(20) not null,#电影名称
Mlanguage varchar(20) not null,#电影语言
Mtype varchar(20) not null,#电影类型
Mpicadress varchar(100),#电影封面
Mduration int not null,#电影时长
Mdetail varchar(200),#电影简介
Mgrade float not null#电影评分
);


create table Cinema#影院
(Cno varchar(10) primary key not null unique ,#影院编号
Aid varchar(20) not null unique,#管理员账号
Cname varchar(20) not null,#影院名称
Caddress varchar(50) not null,#详细地址
Apassword varchar(20) not null,#管理员密码
Ccity varchar(8) not null ,#所在城市
Cip varchar(45) default "123456",#设备编号
Crempass bool default '0' #记住密码
);


create table Userinf#用户
(Uphoneno varchar(20) not null primary key unique,#手机号码
Upassword varchar(20) not null,#用户昵称
Ucity varchar(20) default "定位城市" ,#用户城市
Ublance double not null,#账户余额
Ubirth date default "2000-01-01",#生日
Uphoto char(20) default'yingtao.png',#头像
Usex char(10) not null,#性别
Unickname varchar(20) ,#密码
Uip varchar(45) default "123456",#设备编号
Urempass bool default '0' #记住密码
);



create table Pmessage#上映情况
(Cno varchar(10) not null,#影院编号
Mno varchar(10) not null,#电影编号
primary key (Cno,Mno),
foreign key (Cno) references Cinema(Cno),
foreign key (Mno) references Movie(Mno) on Delete cascade
);



create table Projection#影片场次
(Cno varchar(10) not null,#影院编号
Mno varchar(10) not null,#电影编号
Phall int not null,#放映影厅
Ptime datetime not null,#放映时间
Pamount int not null,#销售数量
Pprice float not null,#销售价格
primary key (Cno,Mno,Phall,Ptime),
foreign key (Cno,Mno) references Pmessage(Cno,Mno) on Delete cascade
);


create table ticket#电影票
(Cno varchar(10) not null ,#电影编号
Mno varchar(10) not null ,#影院编号
Phall int not null,#放映影厅
Ptime datetime not null,#放映时间
Pposition varchar(6) not null,#观影位置
Uphoneno varchar(20) not null,#手机号码
Pprice float not null,#销售价格
primary key (Cno,Mno,Phall,Ptime,Pposition,Uphoneno),
foreign key (Cno,Mno,Phall,Ptime) references Projection(Cno,Mno,Phall,Ptime),
foreign key (Uphoneno) references Userinf(Uphoneno)
);


create view myorder
as
select Userinf.Uphoneno,Movie.Mname,Movie.Mno,Movie.Mduration,Movie.Mpicadress,Cinema.Cno,Cinema.Cname,ticket.Pprice,ticket.Pposition,ticket.Phall,ticket.Ptime
from Userinf,Movie,Cinema,ticket
where Userinf.Uphoneno=ticket.Uphoneno and
Movie.Mno=ticket.Mno and
Cinema.Cno=ticket.Cno
ORDER BY ticket.Ptime DESC;
 
 
create view Sales
as
select Movie.Mname,Movie.Mno,Movie.Mgrade,Movie.Mpicadress,Projection.Cno,Projection.Pprice,sum(Projection.Pamount) as 'Amount',count(*)*81 as 'Total',sum(format((Projection.Pprice*Projection.Pamount) ,2)) as 'Money'
from Movie,Projection
where Movie.Mno=Projection.Mno 
group by Mno,Cno,Pprice
ORDER BY Mgrade;



#插入示例
#电影
insert into movie(Mno,Mname,Mlanguage,Mtype,Mduration,Mgrade,Mpicadress,Mdetail) values('001','你的婚礼','国语','爱情','115','8.0','nidehunli.png','高中时，游泳特长生周潇齐（许光汉饰）对转校生尤咏慈（章若楠饰）一见钟情，年少懵懂的纯纯爱恋，男孩默默守护，但女孩却不告而别。此后的人生，15年的爱情长跑。你的婚礼，也是我的成人礼。');
insert into movie(Mno,Mname,Mlanguage,Mtype,Mduration,Mgrade,Mpicadress,Mdetail) values('002','白蛇2：青蛇劫起','国语','奇幻，动画','131','9.1','baishe2.png','南宋末年，小白（张喆 配）为救许仙（杨天翔 配）水漫金山，终被法海（宋旭晨 配）压在雷峰塔下。小青（唐小喜 配）心生救姐执念，由此被法海杀害，但因其执念落入修罗城幻境经历考验。几次危机中小青被神秘蒙面少年（歪歪 配）所救，小青带着出去救出小白、打倒法海、掀翻雷峰塔的执念历经劫难与成长。强大的执念支撑着她必须要在弱肉强食的修罗城中活下去，带着一世的记忆走出修罗城。');
insert into movie(Mno,Mname,Mlanguage,Mtype,Mduration,Mgrade,Mpicadress,Mdetail) values('003','盛夏未来','国语','剧情、青春','999','9.1','shengxiaweilai.png','即将高考的陈辰（张子枫饰）因发现妈妈（郝蕾饰）与王叔叔（祖峰饰）的“外遇”而心情低落，却在这时与校园网红郑宇星（吴磊饰）因为一个谎言意外相识。两人在未解的青春里，携手面对成长的种种难题，勇敢地面对真实的自己，亦在这个夏天过去后，见证了彼此的成长和蜕变。');
insert into movie(Mno,Mname,Mlanguage,Mtype,Mduration,Mgrade,Mpicadress,Mdetail) values('004','怒火·重案','国语','动作、犯罪','128','9.5','nuhuozhongan.png','重案组布网围剿国际毒枭，突然杀出一组蒙面悍匪“黑吃黑”，更冷血屠杀众警察。重案组督察张崇邦（甄子丹饰）亲睹战友被杀，深入追查发现，悍匪首领竟是昔日战友邱刚敖（谢霆锋饰）。原来敖也曾是警队“明日之星”，而将敖推向罪恶深渊的人，却正是邦。宿命令二人再次纠缠，一切恩怨张崇邦如何作出了断。');
insert into movie(Mno,Mname,Mlanguage,Mtype,Mduration,Mgrade,Mpicadress) values('005','是凑数的','是种语言','是种类型','999','9.9','sansan.jpg');


#影院
insert into Cinema(Cno,Aid,Cname,Ccity,Caddress,Apassword) values('0001','12345678910','万达影院','柳州市','城中区东环大道256号万达广场4楼','123456');
insert into Cinema(Cno,Aid,Cname,Ccity,Caddress,Apassword) values('0002','12345678901','中影影院','广州市','天河区马场路36号太阳新天地8楼','123456');
insert into Cinema(Cno,Aid,Cname,Ccity,Caddress,Apassword) values('0003','18023140417','飞扬影院','广州市','天河区天河路288号正佳广场7楼','123456');
insert into Cinema(Cno,Aid,Cname,Ccity,Caddress,Apassword) values('0004','18023140418','星光影院','广州市','海珠区江南大道中180号富力海珠商业广场B区7楼','123456');
insert into Cinema(Cno,Aid,Cname,Ccity,Caddress,Apassword) values('0005','18023140416','KM影院','河源市','源城区中山大道218号万隆城4楼','123456');
insert into Cinema(Cno,Aid,Cname,Ccity,Caddress,Apassword) values('0006','18023140415','博纳国际影城','深圳市','龙岗区龙岗街道龙岗大道与碧新路交汇处天玑城4楼','123456');

#用户
insert into  userinf (Uphoneno,Upassword,Ublance,Usex) values("13549473975","123456","100","男");
insert into  userinf (Uphoneno,Upassword,Ublance,Usex) values("13418672623","123456","200","女");


#上映情况
insert into Pmessage(Cno,Mno)values('0001','001');
insert into Pmessage(Cno,Mno)values('0002','001');
insert into Pmessage(Cno,Mno)values('0002','002');
insert into Pmessage(Cno,Mno)values('0002','003');
insert into Pmessage(Cno,Mno)values('0002','004');

insert into Pmessage(Cno,Mno)values('0003','001');
insert into Pmessage(Cno,Mno)values('0003','002');
insert into Pmessage(Cno,Mno)values('0003','003');
insert into Pmessage(Cno,Mno)values('0003','004');

insert into Pmessage(Cno,Mno)values('0004','001');
insert into Pmessage(Cno,Mno)values('0004','002');
insert into Pmessage(Cno,Mno)values('0004','003');
insert into Pmessage(Cno,Mno)values('0004','004');

insert into Pmessage(Cno,Mno)values('0005','001');
insert into Pmessage(Cno,Mno)values('0005','002');
insert into Pmessage(Cno,Mno)values('0005','003');
insert into Pmessage(Cno,Mno)values('0005','004');

insert into Pmessage(Cno,Mno)values('0006','001');
insert into Pmessage(Cno,Mno)values('0006','002');
insert into Pmessage(Cno,Mno)values('0006','003');
insert into Pmessage(Cno,Mno)values('0006','004');


#Projection
set @day1=curdate();
set @day2=date_sub(curdate(),interval -1 day);
set @day3=date_sub(curdate(),interval -2 day);
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","001","4",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","001","4",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","001","4",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","001","4",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","001","4",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","001","4",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","001","4",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","001","4",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","002","1",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","002","1",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","002","1",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","002","1",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","002","1",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","002","1",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","002","1",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","002","1",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","003","2",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","003","2",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","003","2",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","003","2",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","003","2",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","003","2",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","003","2",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","003","2",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","004","3",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","004","3",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","004","3",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","004","3",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","004","3",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","004","3",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","004","3",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0004","004","3",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","001","4",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","001","4",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","001","4",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","001","4",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","001","4",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","001","4",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","001","4",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","001","4",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","002","1",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","002","1",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","002","1",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","002","1",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","002","1",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","002","1",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","002","1",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","002","1",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","003","2",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","003","2",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","003","2",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","003","2",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","003","2",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","003","2",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","003","2",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","003","2",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","004","3",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","004","3",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","004","3",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","004","3",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","004","3",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","004","3",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","004","3",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0002","004","3",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","001","4",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","001","4",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","001","4",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","001","4",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","001","4",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","001","4",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","001","4",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","001","4",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","002","1",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","002","1",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","002","1",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","002","1",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","002","1",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","002","1",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","002","1",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","002","1",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","003","2",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","003","2",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","003","2",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","003","2",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","003","2",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","003","2",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","003","2",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","003","2",concat(@day3," 23:00:00"),"0","9.9");

insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","004","3",concat(@day1," 14:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","004","3",concat(@day1," 23:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","004","3",concat(@day2," 10:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","004","3",concat(@day2," 15:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","004","3",concat(@day2," 18:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","004","3",concat(@day2," 21:30:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","004","3",concat(@day3," 13:00:00"),"0","9.9");
insert into Projection(Cno,Mno,Phall,Ptime,Pamount,Pprice)values("0003","004","3",concat(@day3," 23:00:00"),"0","9.9");



#省份
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('11', '直辖市', '1101', '北京市'); 
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('31', '直辖市', '3101', '上海市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('12', '直辖市', '1201', '天津市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('50', '直辖市', '5001', '重庆市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1301', '石家庄市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1302', '唐山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1303', '秦皇岛市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1304', '邯郸市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1305', '邢台市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1306', '保定市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1307', '张家口市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1308', '承德市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1309', '沧州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1310', '廊坊市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('13', '河北省',  '1311', '衡水市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1401', '太原市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1402', '大同市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1403', '阳泉市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1404', '长治市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1405', '晋城市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1406', '朔州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1407', '晋中市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1408', '运城市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1409', '忻州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1410', '临汾市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('14', '山西省',  '1411', '吕梁市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('15', '内蒙古自治区',  '1501', '呼和浩特市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('15', '内蒙古自治区',  '1502', '包头市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('15', '内蒙古自治区',  '1503', '乌海市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('15', '内蒙古自治区',  '1504', '赤峰市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('15', '内蒙古自治区',  '1505', '通辽市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('15', '内蒙古自治区',  '1506', '鄂尔多斯市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('15', '内蒙古自治区',  '1507', '呼伦贝尔市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('15', '内蒙古自治区',  '1508', '巴彦淖尔市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('15', '内蒙古自治区',  '1509', '乌兰察布市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2101', '沈阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2102', '大连市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2103', '鞍山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2104', '抚顺市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2105', '本溪市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2106', '丹东市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2107', '锦州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2108', '营口市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2109', '阜新市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2110', '辽阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2111', '盘锦市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2112', '铁岭市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2113', '朝阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('21', '辽宁省',  '2114', '葫芦岛市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('22', '吉林省',  '2201', '长春市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('22', '吉林省',  '2202', '吉林市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('22', '吉林省',  '2203', '四平市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('22', '吉林省',  '2204', '辽源市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('22', '吉林省',  '2205', '通化市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('22', '吉林省',  '2206', '白山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('22', '吉林省',  '2207', '松原市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('22', '吉林省',  '2208', '白城市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2301', '哈尔滨市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2302', '齐齐哈尔市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2303', '鸡西市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2304', '鹤岗市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2305', '双鸭山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2306', '大庆市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2307', '伊春市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2308', '佳木斯市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2309', '七台河市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2310', '牡丹江市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2311', '黑河市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('23', '黑龙江省',  '2312', '绥化市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3201', '南京市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3202', '无锡市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3203', '徐州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3204', '常州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3205', '苏州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3206', '南通市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3207', '连云港市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3208', '淮安市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3209', '盐城市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3210', '扬州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3211', '镇江市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3212', '泰州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('32', '江苏省',  '3213', '宿迁市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3301', '杭州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3302', '宁波市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3303', '温州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3304', '嘉兴市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3305', '湖州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3306', '绍兴市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3307', '金华市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3308', '衢州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3309', '舟山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3310', '台州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('33', '浙江省',  '3311', '丽水市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3401', '合肥市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3402', '芜湖市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3403', '蚌埠市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3404', '淮南市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3405', '马鞍山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3406', '淮北市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3407', '铜陵市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3408', '安庆市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3410', '黄山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3411', '滁州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3412', '阜阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3413', '宿州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3415', '六安市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3416', '亳州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3417', '池州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('34', '安徽省',  '3418', '宣城市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('35', '福建省',  '3501', '福州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('35', '福建省',  '3502', '厦门市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('35', '福建省',  '3503', '莆田市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('35', '福建省',  '3504', '三明市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('35', '福建省',  '3505', '泉州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('35', '福建省',  '3506', '漳州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('35', '福建省',  '3507', '南平市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('35', '福建省',  '3508', '龙岩市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('35', '福建省',  '3509', '宁德市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3601', '南昌市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3602', '景德镇市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3603', '萍乡市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3604', '九江市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3605', '新余市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3606', '鹰潭市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3607', '赣州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3608', '吉安市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3609', '宜春市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3610', '抚州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('36', '江西省',  '3611', '上饶市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3701', '济南市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3702', '青岛市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3703', '淄博市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3704', '枣庄市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3705', '东营市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3706', '烟台市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3707', '潍坊市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3708', '济宁市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3709', '泰安市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3710', '威海市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3711', '日照市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3713', '临沂市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3714', '德州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3715', '聊城市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3716', '滨州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('37', '山东省',  '3717', '菏泽市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4101', '郑州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4102', '开封市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4103', '洛阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4104', '平顶山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4105', '安阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4106', '鹤壁市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4107', '新乡市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4108', '焦作市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4109', '濮阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4110', '许昌市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4111', '漯河市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4112', '三门峡市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4113', '南阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4114', '商丘市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4115', '信阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4116', '周口市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('41', '河南省',  '4117', '驻马店市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4201', '武汉市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4202', '黄石市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4203', '十堰市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4205', '宜昌市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4206', '襄阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4207', '鄂州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4208', '荆门市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4209', '孝感市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4210', '荆州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4211', '黄冈市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4212', '咸宁市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('42', '湖北省',  '4213', '随州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4301', '长沙市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4302', '株洲市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4303', '湘潭市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4304', '衡阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4305', '邵阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4306', '岳阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4307', '常德市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4308', '张家界市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4309', '益阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4310', '郴州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4311', '永州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4312', '怀化市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('43', '湖南省',  '4313', '娄底市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4401', '广州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4402', '韶关市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4403', '深圳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4404', '珠海市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4405', '汕头市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4406', '佛山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4407', '江门市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4408', '湛江市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4409', '茂名市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4412', '肇庆市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4413', '惠州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4414', '梅州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4415', '汕尾市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4416', '河源市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4417', '阳江市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4418', '清远市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4451', '潮州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4452', '揭阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('44', '广东省',  '4453', '云浮市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4501', '南宁市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4502', '柳州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4503', '桂林市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4504', '梧州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4505', '北海市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4506', '防城港市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4507', '钦州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4508', '贵港市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4509', '玉林市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4510', '百色市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4511', '贺州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4512', '河池市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4513', '来宾市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('45', '广西壮族自治区',  '4514', '崇左市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('46', '海南省',  '4601', '海口市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('46', '海南省',  '4602', '三亚市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5101', '成都市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5103', '自贡市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5104', '攀枝花市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5105', '泸州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5106', '德阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5107', '绵阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5108', '广元市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5109', '遂宁市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5110', '内江市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5111', '乐山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5113', '南充市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5114', '眉山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5115', '宜宾市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5116', '广安市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5117', '达州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5118', '雅安市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5119', '巴中市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('51', '四川省',  '5120', '资阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('52', '贵州省',  '5201', '贵阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('52', '贵州省',  '5203', '遵义市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('52', '贵州省',  '5204', '安顺市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('52', '贵州省',  '5205', '毕节市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('52', '贵州省',  '5206', '铜仁市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('53', '云南省',  '5301', '昆明市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('53', '云南省',  '5303', '曲靖市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('53', '云南省',  '5304', '玉溪市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('53', '云南省',  '5305', '保山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('53', '云南省',  '5306', '昭通市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('53', '云南省',  '5307', '丽江市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('53', '云南省',  '5308', '普洱市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('53', '云南省',  '5309', '临沧市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('54', '西藏自治区', '5401', '拉萨市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('54', '西藏自治区', '5405', '山南市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6101', '西安市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6102', '铜川市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6103', '宝鸡市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6104', '咸阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6105', '渭南市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6106', '延安市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6107', '汉中市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6108', '榆林市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6109', '安康市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('61', '陕西省',  '6110', '商洛市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6201', '兰州市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6203', '金昌市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6204', '白银市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6205', '天水市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6206', '武威市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6207', '张掖市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6208', '平凉市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6209', '酒泉市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6210', '庆阳市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6211', '定西市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('62', '甘肃省',  '6212', '陇南市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('63', '青海省',  '6301', '西宁市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('64', '宁夏回族自治区', '6401', '银川市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('64', '宁夏回族自治区', '6402', '石嘴山市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('64', '宁夏回族自治区', '6403', '吴忠市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('64', '宁夏回族自治区','6404', '固原市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('64', '宁夏回族自治区','6405', '中卫市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('65', '新疆维吾尔自治区', '6501', '乌鲁木齐市');
INSERT INTO `region`(`province_code`, `province`, `city_code`, `city`) VALUES ('65', '新疆维吾尔自治区', '6502', '克拉玛依市');