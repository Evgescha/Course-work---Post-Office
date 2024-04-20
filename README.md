# Задание 11– Почтовое отделение
Пусть требуется создать программную систему, предназначенную для работников почтового отделения. Такая система должна обеспечивать хранение сведений о подписчиках газет и журналов, обслуживаемых отделением связи, и о почтальонах.
Каждое подписное издание характеризуется индексом, названием и подписной ценой.  Данные о подписчиках включают в себя: фамилию, имя, отчество, домашний адрес, индексы получаемых изданий, дату, начиная с которой оформлена подписка, и срок подписки на каждое издание. Несколько домов объединяются в участок, который обслуживается одним почтальоном. Каждый почтальон может обслуживать несколько участков. В БД должны содержаться сведения о том, к каким участкам относятся подписчики газет, и об обслуживающем их почтальоне. Заведующий почтовым отделением может принять на работу и уволить почтальона, при этом участки не должны оставаться без обслуживания. Оператор почтовой связи должен иметь возможность по просьбе клиента оформить подписку, а также добавить в БД сведения о новом подписном издании. Оформление подписки связано с выдачей клиенту квитанции, в которой указывается общая стоимость подписки, что выписано, и на какой срок.

Возможны следующие запросы к БД:
1.	Определить наименование и количество экземпляров всех изданий, получаемых отделением связи.
2.	Определить у кого истекает срок подписки через две недели.
3.	По заданному адресу определить фамилию почтальона, обслуживающего подписчика.
4.	Вывести всех подписчиков, кого обслуживает заданный почтальон.
5.	Какие журналы выписывает гражданин с указанной фамилией, именем, отчеством?
6.	Сколько почтальонов работает в почтовом отделении?
7.	На каком участке количество экземпляров подписных изданий минимально?
8.	Каков средний срок подписки по каждому изданию?
9.	Количество всех подписчиков указанного издания?
10.	Количество подписчиков указанного издания по всем участкам?

Необходимо предусмотреть   возможность получения отчета о доставке почтой газет и журналов. Отчет должен быть упорядочен по участкам. Для каждого участка указывается фамилия и инициалы почтальона, обслуживающего участок, и перечень доставляемых изданий (индекс и название издания, адрес доставки, срок подписки). По каждому изданию указывается средний срок подписки и количество экземпляров, а по участку – количество различных подписных изданий. В отчете должно быть указано сколько почтальонов работает в почтовом отделении, сколько всего участков оно обслуживает, сколько различных изданий доставляет подписчикам.

## Главная и рабочие формы приложения
 
 ![image](https://github.com/Evgescha/Course-work---Post-Office/assets/38140129/a2cac6b2-1d68-4e02-90c9-9369274faf70)

Рисунок C.1 – Главная форма приложения
 
 ![image](https://github.com/Evgescha/Course-work---Post-Office/assets/38140129/c7971fbc-daa4-495b-9ef5-1e995d974f0d)

Рисунок C.2 – Форма работы с почтальонами
 
 ![image](https://github.com/Evgescha/Course-work---Post-Office/assets/38140129/7aed5b13-2306-4390-a4a6-908b451e7ee1)

Рисунок C.3 – Форма генерации квитанции за подписку по подписчику и дате подписки