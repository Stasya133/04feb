

Ну и в заключении поговорим о самом GIT

* # Первое

Чтобы начать работать в нем, надо создать папку ==>

==> через VScode, создаем файл в нашем случае с расширением .md ==>

==> Создаем/Инициализируем <font color = red> Репозиторий </font>командой <font size = 6> git init </font>

* # Добавляем и сохраняем

==> добавляем файл в сохранение/сохраняем командой <font size = 6> git add и пишем название файла (который создали с расширением .md) </font>

==> теперь смотрим, что произошло, с помощью команды <font size = 6> git  status</font>

==> сохраняем текущее состаяние файлов <font size = 6> git commit -m "Даем имя commitу"</font>, а если мы не хотим тратить время на название коммита, можно просто написать например так: <font size = 6> git commit -am "aaa"</font>

==> провериv, что у нас там в событиях произошо (в журнале событий/изменений) <font size = 6> git  log</font>

==> можем вернуться к другому commit <font size = 6> git checkout и пишем первые 4 символа commitа</font>

==> Если вдруг у нас случился в терминале <font size = 4> END </font> нажимаем нра клавиатуре кнопочку <font size = 4> Q </font>

==> наверное хочется посмотреть, что мы там наизменяли, с этим нам поможет команда <font size = 6> git diff </font>

* # Ветки 

==> Кстати самый первый commit принято называть <font size = 4> Initial commit </font>

==> Создаем новую ветку 😃 <font size = 6> git branch name branch</font>

==> а если у нас терминал уже далеко уполз можно просто написать <font size = 4> clear </font>

==> можем перемещатся между ветками <font size = 6> git checkout name branch</font>

==> можно быстрее все это сделать сразу создать ветку и перейти в нее <font size = 6> git checkout -b name branch</font>

==> когда мы поработали в новой ветке и нам надо данные из нее переести в исходную ветку, делаем так сначала, переходим в исходную ветку, а потом в ней пишем команду   <font size = 6> git merge name branch</font>

==> и теперь мы удаляем ветку из которой все перенесли, она же нам не нужна <font size = 6> git branch -d </font>

==> посмотрим все наши commitы <font size = 6> git log -graph </font>

==> И конечно  интересно посмотреть, что мы делали с commitами, в какие ветки прыгали, с этим нам поможет <font size = 6> git reflog </font>

---

==> Полезный файл <font size = 6> .gitignore </font> чтобы не сохранялась ненужная информация

---

Продолжим нашу инструкцию чуть позже, сначала узнаем их)

---

Продолжаем изучать GIT

==> Чтобы нам выполнить ДЗ, надо: 

==> 1. Делаем у себя в аккаунте репозиторий такой же как у другого, для этого на страничке GItHub, в аккаунте другого пользователя, надо нажать <font size = 6> Fork </font> ![Fork](Fork.png)

==> Клонируем репозиторий репозиторий <font size = 6> git clone </font> и вставляем путь скопированный ![Fork](Клонирование.png), в открывшемся окошке копируем ![Fork](Clone1.png)

==> Отправить файл в репозиторий  <font size = 6> git push </font>

==> Скачать актуальное состояние репозитория еще и с merge <font size = 6> git pull </font>














