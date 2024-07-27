## Описание
Приложение для взаимодействия и управления файловой системой
## Тенхологии
C#, .NET 8.0, XUnit, Mock тестирование
## Семантика команд
- `connect [Address] [-m Mode]` <br />
  Address - абсолютный путь в подключаемой файловой системе  <br />
  Mode - режим файловой системы (реализована локальная ФС, значение `local`)
- `disconnect`  <br />
  Отключение от файловой системы
- `tree goto [Path]`  <br />
  Path - относительный или абсолютный путь до каталога в файловой системе
- `tree list {-d Depth}` <br />
  Depth - параметр, определяющий глубину выборки, должен объявляться флагом `-d`
- `file show [Path] {-m Mode}`  <br />
  Path - относительный или абсолютный путь до файла
  Mode - режим вывода файла (реализован консольный, значение `console`)
- `file move [SourcePath] [DestinationPath]`  <br />
  SourcePath - относительный или абсолютный путь до перемещаемого файла
  DestinationPath - относительный или абсолютный  путь до директории, куда файл должен быть перемещён
- `file copy [SourcePath] [DestinationPath]` <br />
  SourcePath - относительный или абсолютный путь до копируемого файла
  DestinationPath - относительный или абсолютный путь до директории, куда файл должен быть скопирован
- `file delete [Path]`  <br />
  Path - относительный или абсолютный путь до удаляемого файла
- `file rename [Path] [Name]` <br />
  Path - относительный или абсолютный путь до изменяемого файла
  Name - новое имя файла
