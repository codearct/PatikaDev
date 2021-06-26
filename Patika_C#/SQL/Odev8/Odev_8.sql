--CREATE TABLE employee(
--	id SERIAL PRIMARY KEY,
--	name VARCHAR(50) NOT NULL,
--	birthday DATE,
--	email VARCHAR(100)
--);

/*insert into employee (name, birthday, email) values ('Karly Cutbirth', '1904-03-19 11:36:17', 'kcutbirth0@tiny.cc');
insert into employee (name, birthday, email) values ('Auria Yegorovnin', '1926-08-25 23:25:39', 'ayegorovnin1@weibo.com');
insert into employee (name, birthday, email) values ('Humbert Conyer', '1923-10-12 12:24:33', 'hconyer2@fastcompany.com');
insert into employee (name, birthday, email) values ('Aurelie Alldridge', '1929-11-03 23:14:40', 'aalldridge3@economist.com');
insert into employee (name, birthday, email) values ('Vonni Aronstein', '1996-09-21 12:26:23', 'varonstein4@rediff.com');
insert into employee (name, birthday, email) values ('Ambur Dewire', '1908-09-10 03:23:08', 'adewire5@sciencedaily.com');
insert into employee (name, birthday, email) values ('Kirsteni Stanborough', '1906-01-11 10:41:40', 'kstanborough6@adobe.com');
insert into employee (name, birthday, email) values ('Rhiamon Newcom', '1967-11-12 18:26:42', 'rnewcom7@foxnews.com');
insert into employee (name, birthday, email) values ('Ariana Ridgewell', '1966-01-16 20:59:36', 'aridgewell8@whitehouse.gov');
insert into employee (name, birthday, email) values ('Rhoda Gosneye', null, null);
insert into employee (name, birthday, email) values ('Ebeneser Chevalier', '1933-04-25 15:13:07', 'echevaliera@cornell.edu');
insert into employee (name, birthday, email) values ('Kylila Sibbson', '1954-01-09 14:06:47', 'ksibbsonb@domainmarket.com');
insert into employee (name, birthday, email) values ('Elbert Plenty', '1965-10-30 07:09:40', 'eplentyc@marriott.com');
insert into employee (name, birthday, email) values ('Tamra Sexty', '1927-09-21 10:13:33', 'tsextyd@google.es');
insert into employee (name, birthday, email) values ('Almeria Brooking', '1932-08-13 00:24:37', 'abrookinge@elpais.com');
insert into employee (name, birthday, email) values ('Ema Simants', '1984-04-15 06:18:16', 'esimantsf@youtu.be');
insert into employee (name, birthday, email) values ('Martha Hacun', '1989-06-01 16:11:59', 'mhacung@sitemeter.com');
insert into employee (name, birthday, email) values ('Kissie Greenhaugh', '1928-01-26 20:55:11', 'kgreenhaughh@omniture.com');
insert into employee (name, birthday, email) values ('Damara Colvill', '1935-12-22 10:01:08', 'dcolvilli@miibeian.gov.cn');
insert into employee (name, birthday, email) values ('Amos McGuggy', '1903-11-11 13:30:28', 'amcguggyj@pinterest.com');
insert into employee (name, birthday, email) values ('Andre Maffucci', '1963-12-31 22:37:38', 'amaffuccik@delicious.com');
insert into employee (name, birthday, email) values ('Griffin Pohlak', '1960-03-08 02:39:36', 'gpohlakl@nbcnews.com');
insert into employee (name, birthday, email) values ('Daffy Chilley', '1956-03-20 18:47:51', 'dchilleym@wix.com');
insert into employee (name, birthday, email) values ('Umeko Thelwll', '1907-12-05 03:06:20', 'uthelwlln@un.org');
insert into employee (name, birthday, email) values ('Frankie Danielsson', '1912-12-05 05:45:05', 'fdanielssono@vimeo.com');
insert into employee (name, birthday, email) values ('Sallie Comport', '1999-08-29 07:35:28', 'scomportp@ftc.gov');
insert into employee (name, birthday, email) values ('Bucky Moth', '1954-05-08 22:42:16', 'bmothq@usatoday.com');
insert into employee (name, birthday, email) values ('Judie Shattock', '1960-06-05 09:27:55', 'jshattockr@admin.ch');
insert into employee (name, birthday, email) values ('Shirl Stennings', '1935-10-19 14:33:47', 'sstenningss@myspace.com');
insert into employee (name, birthday, email) values ('Berny MacAnespie', null, null);
insert into employee (name, birthday, email) values ('Tamar Dominique', '1906-12-31 08:36:09', 'tdominiqueu@unesco.org');
insert into employee (name, birthday, email) values ('Delmar Dingley', '1921-12-24 21:28:32', 'ddingleyv@toplist.cz');
insert into employee (name, birthday, email) values ('Peggi Cramphorn', '1974-08-24 00:05:56', 'pcramphornw@cnn.com');
insert into employee (name, birthday, email) values ('Abby McKim', '1939-05-19 10:48:40', 'amckimx@bizjournals.com');
insert into employee (name, birthday, email) values ('Davon Petchey', '1998-10-22 08:55:12', 'dpetcheyy@hud.gov');
insert into employee (name, birthday, email) values ('Fabio O''Grogane', '1938-02-16 11:46:40', 'fogroganez@parallels.com');
insert into employee (name, birthday, email) values ('Fraze Steuhlmeyer', null, null);
insert into employee (name, birthday, email) values ('Harriot Maldin', '1911-03-17 19:04:00', 'hmaldin11@livejournal.com');
insert into employee (name, birthday, email) values ('Ebonee Swadling', '1997-05-25 13:40:08', 'eswadling12@seattletimes.com');
insert into employee (name, birthday, email) values ('Felecia Torrisi', '1947-05-21 01:04:11', 'ftorrisi13@canalblog.com');
insert into employee (name, birthday, email) values ('Ajay Linster', '1999-07-12 12:54:48', 'alinster14@msu.edu');
insert into employee (name, birthday, email) values ('Dora O'' Donohoe', '1947-11-12 19:44:49', 'do15@apache.org');
insert into employee (name, birthday, email) values ('Mag Frear', '1926-07-16 22:39:17', 'mfrear16@so-net.ne.jp');
insert into employee (name, birthday, email) values ('Pennie Brakespear', '1965-07-19 03:38:48', 'pbrakespear17@ibm.com');
insert into employee (name, birthday, email) values ('Lynda O''Breen', '1912-08-16 17:00:44', 'lobreen18@vimeo.com');
insert into employee (name, birthday, email) values ('Blisse Francescuzzi', '1963-05-10 13:39:54', 'bfrancescuzzi19@ycombinator.com');
insert into employee (name, birthday, email) values ('Courtnay Maxwale', '1978-06-04 05:50:27', 'cmaxwale1a@mysql.com');
insert into employee (name, birthday, email) values ('Irma Eliyahu', '1944-11-10 22:01:40', 'ieliyahu1b@pcworld.com');
insert into employee (name, birthday, email) values ('Raoul Garmston', '1977-07-13 05:33:24', 'rgarmston1c@rakuten.co.jp');
insert into employee (name, birthday, email) values ('Editha Probet', '1911-08-18 05:00:48', 'eprobet1d@edublogs.org');*/

-- UPDATE employee
-- SET name ='Deniz Cingöz',
-- birthday='1922-01-25',
-- email='dc2501@gmail.com'
-- WHERE name ='Damara Colvill';

-- UPDATE employee
-- SET name ='Asya Katır',
-- birthday='1982-10-23',
-- email='ak1023@gmail.com'
-- WHERE id =13;

-- UPDATE employee
-- SET name ='Yılmaz Bekçi',
-- birthday='1985-07-08',
-- email='bekyilmaz@gmail.com'
-- WHERE birthday ='1908-09-10';

-- UPDATE employee
-- SET name ='Dilara Kızıl',
-- birthday='1983-08-12',
-- email='kizil83@gmail.com'
-- WHERE email ='rnewcom7@foxnews.com';

-- UPDATE employee
-- SET name ='Ayşe Fatma',
-- birthday='1999-08-17',
-- email='bykykm@gmail.com'
-- WHERE name LIKE 'Ariana%';

-- DELETE FROM employee
-- WHERE id = 5;

-- DELETE FROM employee
-- WHERE name = 'Kirsteni Stanborough';

-- DELETE FROM employee
-- WHERE birthday IS NULL;

-- DELETE FROM employee
-- WHERE email LIKE '%@omniture.com';










