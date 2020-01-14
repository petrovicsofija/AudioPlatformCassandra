CREATE KEYSPACE audioplatform
WITH replication = {'class': 'SimpleStrategy', 'replication_factor' : 3};
USE audioplatform;
CREATE TABLE "AudioPlatform"(
name text PRIMARY KEY,
price double,
description text,
);
CREATE TABLE "Song"(
url text,
name text,
autor text,
genre text,
audio_tier text,
PRIMARY KEY(name,autor,audio_tier)
);
CREATE TABLE "Contract"(
start_date date,
end_date date,
audio_tier text,
customer_name text,
customer_surname text,
PRIMARY KEY(start_date,customer_name,customer_surname,audio_tier)
);
CREATE TABLE "Customer"(
name text,
surname text,
email text,
password text,
birth_date date,
audio_tier text,
audio_price double,
contract_start_date date,
contract_end_date date,
PRIMARY KEY(email,password,audio_tier)
);
CREATE TABLE "AudioTierRating"(
description text,
evaluation double,
customer_name text,
customer_surname text,
customer_email text,
platform text,
PRIMARY KEY(description,customer_email)
);
------ SELECT
select * from audioplatform."Song" where name='Oh,Pretty Woman' and autor='Roy Orbison' and audio_tier=3; 