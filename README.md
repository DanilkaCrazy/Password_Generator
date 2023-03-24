# Генератор Паролей/Password Generator
## Создание простого генератора паролей на языке программирования С#

Простой генератор случайных паролей - это приложение, которое случайным образом генерирует последовательность чисел или букв и специальных символов, или при выборе в параметрах соответствующей кнопки (CheakBox), - все вместе. В последнем случае пароль становится качественным и безопасным, неуязвимым ко взлому и более универсальным.

### Шаг 1. Создать проект в Microsoft Visual Studio (в моем случае: версия 2019 года, Community).
Выбираем среди открывшихся шаблонов "Приложение Windows Forms (.NET Framework). Нажимаем Далее.

![Screenshot_1](https://user-images.githubusercontent.com/95550202/227464467-0f7b099f-09c3-4577-b85a-de6c13673043.png)

### Шаг 2. Создаем визуальный интерфейс для работы приложения.
После загрузки отобразится пустая форма нашего приложения:

![Screenshot_3](https://user-images.githubusercontent.com/95550202/227466375-a6328e00-8162-4df9-959e-860ffe3ea93b.png)

Изменить название формы (Text) можно в "Свойствах" формы, там же можно поменять или вообще удалить иконку (Icon):

![Screenshot_4](https://user-images.githubusercontent.com/95550202/227466908-eaa6f449-f550-4ded-ae53-ccf17e043467.png)

Поиск и добавление компонентов осуществляется через "Панель элементов"

![Screenshot_5](https://user-images.githubusercontent.com/95550202/227467611-88f26e02-8dba-4f93-8df4-9c7fef03d9e8.png)

В моем случае были выбраны следующие компоненты:

![Screenshot_1](https://user-images.githubusercontent.com/95550202/227501774-0128593d-b7de-4c58-b658-4678d02d4c39.png)

### Шаг 3. Когда дизайн готов - переходим к коду!
Открыть область, где нужно писать код можно множеством способов, самый легкий - щелкнуть 2 раза по каждой кнопке Button.

В кнопке Clear записан следующий код:

![Screenshot_3](https://user-images.githubusercontent.com/95550202/227503236-fcae7b7e-439e-4331-920d-2efdeb19f869.png)

Но с описанием кода кнопки Generate нужно немного потрудиться (он длинноват):

![Screenshot_4](https://user-images.githubusercontent.com/95550202/227503910-07e583c5-7e6f-4d71-8e88-6d41f6089c7d.png)

### Шаг 4. Разбор кода.
В кнопке Clear создана функция для очистки текстового поля (RichTextBox).
В начале кода кнопки Generate созданы переменные, которые необходимо связать с компонентами из интерфейса (также преобразовали их под нужный тип).
В компонентах NumericUpDown используются только числовые значения. Для компонента CheakBox необходим тип логического значения.
Теперь переходим дальше - к циклам.
Цикл for (int k = 0; k < quant; k++) реализует подсчет до необходимого числа значений (включительно), которое нужно указать в кнопке "Количество". Позже можно наблюдать, что если указано число 0, то применяется возврат каретки richTextBox1.Text += "\n" и осуществляется переход на новую строку. В цикле for (int i = 0; i < length_pass; i++) идет подсчет длины пароля до необходимого числа (включительно), введенного нами в программе в Password length. Далее составлено несколько диапазонов выбора рандомных чисел, но зачем? В первом диапазоне Next(0, 2) - рандомно выбираем 3 числа: 0, 1, 2. И чтобы соответсовать условиям, включаем в один диапазон следующий, который лежит в теле условия. Таким образом у нас есть условие, которое работает при включеном флажке CheakBox(true) и исправно соответствует смыслу, заложенное в это условие, то есть использование символов и специальных знаков. Следующие условия работают по аналогии.

### Шаг 5. Тестирование программы.
Основной вид, после запуска:

![Screenshot_2](https://user-images.githubusercontent.com/95550202/227510857-f3192ecc-7efa-4d04-91f3-74cb1ec7acb1.png)

Вводим любые числа, не используя доп. символы:

![Screenshot_5](https://user-images.githubusercontent.com/95550202/227511119-075c789c-3ff8-440b-b8c6-2e710fdc68aa.png)

Стираем выведенные комбинации:

![Screenshot_6](https://user-images.githubusercontent.com/95550202/227511219-2d2f2cf3-31e9-4a07-99f0-3d414b14eb1f.png)

Используем доп. символы и знаки:

![Screenshot_7](https://user-images.githubusercontent.com/95550202/227511291-61a08a62-5760-4cd9-beb5-7f7267e63890.png)

При вводе 0 в длине пароля применяется перенос строки (в данном случае можно улучшить функционал и создать ошибку):

![Screenshot_8](https://user-images.githubusercontent.com/95550202/227511630-88fec2df-cdb1-43be-ac52-f9537f0757c5.png)

Программа работает! Радуйтесь и наслаждайтесь)

