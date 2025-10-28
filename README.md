# 📚 Estudo POO e Manipulacao de Json

Este repositório é um projeto de estudo focado no estudo de programação orientada a objetos e manipulação de Json onde utilizado um arquivo Json como minha base de dados, no projeto pode ser encotrado algumas consultas linq, mas esse não é o foco desse repositório.

O objetivo é demonstrar o entendimento sobre a programação orientada a objetos e manipulação de arquivos Json com diferentes itens, aplicando as melhores práticas para legibilidade.

## ✨ Conceitos e Tecnologias Utilizadas

### 1. Programação Orientada a Objetos (POO)

O projeto foi estruturado utilizando os pilares da POO para criar um código mais organizado, reutilizável e extensível.

*   **Abstração:** A classe `MidiaBase` foi criada como uma classe `abstract`, definindo um contrato comum (propriedades como `Id` e `Titulo`) que toda mídia no sistema deve ter, sem poder ser instanciada diretamente.
*   **Herança:** Classes concretas como `Filme` e `Serie` herdam de `MidiaBase`, reutilizando seus atributos e comportamentos e adicionando os seus próprios, se necessário.
*   **Polimorfismo:** A aplicação manipula uma única lista do tipo `List<MidiaBase>`. Graças ao polimorfismo, essa lista pode armazenar objetos de qualquer classe que herde de `MidiaBase` (como `Filme`, `Serie`, etc.), permitindo que o sistema trate diferentes tipos de mídia de forma uniforme.
*   **Encapsulamento:** As classes agrupam seus dados (propriedades) e os comportamentos que operam nesses dados (métodos), controlando o acesso e mantendo a integridade do objeto.

### 2. Manipulação de JSON como Banco de Dados

Para persistir os dados, o projeto utiliza um arquivo `dados.json` local, simulando um banco de dados.

*   **Newtonsoft.Json:** A biblioteca `Newtonsoft.Json` (Json.NET) é utilizada para serializar (converter objetos C# para uma string JSON) e desserializar (converter a string JSON de volta para uma lista de objetos C#).
*   **Repositório de Dados:** A classe `JsonRepositorio` centraliza toda a lógica de leitura e escrita no arquivo `dados.json`, abstraindo essa complexidade do resto da aplicação.
*   **Suporte a Polimorfismo na Serialização:** A configuração `TypeNameHandling` é usada para incluir metadados de tipo (`$type`) no arquivo JSON. Isso é crucial para que, ao ler o arquivo, o `Newtonsoft.Json` saiba qual classe concreta (`Filme`, `Serie`, etc.) instanciar para cada item da lista `List<MidiaBase>`.

### 3. Estrutura do Projeto

*   **Classes Estáticas:** Foram utilizadas classes estáticas (`Menu`, `Cadastrar`, `Alterar`, etc.) para agrupar funcionalidades que não precisam de estado, como a exibição de menus e a orquestração de ações do usuário.
*   **Gerador de ID:** Uma classe estática `IdGenerator` garante a criação de IDs únicos para cada nova mídia cadastrada durante a execução do programa.

## 🚀 Como Rodar o Projeto

Para executar este projeto, você precisará ter o [.NET SDK 8](https://dotnet.microsoft.com/download) instalado em sua máquina.

1.  **Clone o Repositório (Opcional)**
    Se o projeto estiver em um repositório Git, clone-o:
    ````bash
    git clone https://github.com/Ca22io/Estudo-POO-Manipulacao-Json
    cd <nome-do-projeto>
    ````

2.  **Abra o Terminal**
    Navegue até a pasta raiz do projeto (a pasta que contém o arquivo `.csproj`).

3.  **Execute o Projeto**
    Use o seguinte comando do .NET CLI para compilar e rodar a aplicação:
    ````bash
    dotnet run
    ````

4.  **Interaja com o Menu**
    O menu principal será exibido no console. Digite o número da opção desejada e pressione `Enter` para interagir com o catálogo. O arquivo `data/dados.json` será criado ou atualizado automaticamente na raiz do projeto.
