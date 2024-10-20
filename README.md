# P.O.O - Atividade Extra

## Descrição
Repositório feito especificamente para a atividade extra da disciplina de Programação Orientada a Objetos do curso Tecnólogo em Análise e Desenvolvimento de Sistemas, no IFPI.

## Respostas das questões propostas

### 1. Diferença entre uma classe e um objeto

#### Enunciado
Explique com suas palavras a diferença entre uma classe e um objeto e como esses dois conceitos se relacionam. Além disso, apresente um exemplo do mundo real para cada um (por exemplo, usando a classe `Carro` e instâncias como `Fusca` e `Civic`).

#### Sobre as diferenças
- **Classe:** É uma estrutura que define características (atributos) e comportamentos (métodos) comuns a um conjunto de objetos, servindo como um modelo.
<br>

- **Objeto:** É o elemento real criado a partir da definição da classe, possuindo os seus próprios valores para os atributos definidos na classe e podendo executar os métodos previamente definidos. Em outras palavras, um objeto é uma instância de uma classe.

#### Exemplo do mundo real
- Classe: `Animal`
- Objeto 1: `Cachorro` com atributos como `Raca = "Labrador"` e `Idade = 5`
- Objeto 2: `Gato` com atributos como `Raca = "Siamês"` e `Idade = 10`

### 2. Conceituação de atributos e métodos

#### Enunciado
De forma breve, conceitue atributos e métodos. Pesquise e exemplifique um objetos ou classes que possuam atributos e métodos. Por exemplo um Carro:

- **Classe:** `Carro`
- **Atributos:** `cor`, `marca`, `ano`
- **Métodos:** `acelerar()`, `frear()`

#### Conceito
- **Atributos:** São as características que descrevem um objeto, representando os dados armazenados em cada instância.
<br>

- **Métodos:** São as ações ou comportamentos que um objeto pode realizar, representando as operações que podem ser aplicadas aos seus atributos.

#### Exemplo
- **Classe:** `Pessoa`
- **Atributos:** `Nome`, `Idade`, `Altura`
- **Métodos:** `Andar()`, `Falar()`

### 3. Abstração e relevância de atributos em diferentes contextos

#### Enunciado
A abstração visa focar no que é importante para um sistema. Você concorda que um atributo de uma pessoa pode ser importante ou não dependendo do contexto do sistema? Enumere na tabela apresentada contextos/sistemas distintos em que os atributos abaixo seriam relevantes

#### Sobre a importância da abstração
Sim, a abstração serve justamente para que se possa manter foco nos atributos relevantes para um determinado contexto. Um atributo que é essencial em um contexto, pode ser totalmente irrelevante em outro.

#### A tabela

| Atributo                 | Sistema em que não é importante | Sistema em que é moderadamente importante| Sistema em que é essencial         |
|--------------------------|---------------------------------|------------------------------------------|------------------------------------|
| CPF                      | Jogo eletrônico                 | Loja de produtos virtuais                | Sistema bancário                   |
| Histórico de saúde       | Sistema de compras online       | Academia                                 | Sistema hospitalar                 |
| Quantidade de seguidores | Sistema bancário                | Jogo online                              | Rede social                        |
| Habilidade destra        | Sistema de compras online       | Jogo eletrônico                          | Sistema de ergonomia no trabalho   |
| Endereço                 | Jogo eletrônico                 | Sistema de mapas                         | Entrega de mercadorias             |
| Saldo em conta           | Sistema de meteorologia         | Jogo eletrônico                          | Sistema bancário                   |
| Etnia                    | Sistema bancário                | Sistema de pesquisa eleitoral            | Sistema de pesquisa social         |

### 4. Relação entre `Pessoa` e `Conta`

#### Enunciado
Considerando os objetos Pessoa e Conta:

**A -** Seria interessante em um sistema bancário um objeto "conta" possuir uma "pessoa" como um atributo interno representando o titular da conta?

**B -** Olhando no sentido inverso, seria interessante uma pessoa possuir mais de uma conta como atributo? Que elemento da programação estruturada melhor representaria o conjunto de contas de uma pessoa?

#### Resposta da letra A.
Em um sistema bancário, seria interessante que um objeto `Conta` tivesse um atributo `Pessoa`, representando o titular da conta, se aproximando mais do contexto da vida real.

#### Resposta da letra B.
Seria interessante uma pessoa possuir mais de uma conta como atributo. O conjunto de contas de uma pessoa poderia ser representado por uma estrutura de dados, como um *array*, para armazenar as diversas contas associadas a essa pessoa.

### 5. Objetos de um sistema de controle acadêmico

#### Enunciado
Identifique pelo menos 5 objetos de um sistema de controle acadêmico. Ex: `Aluno`, `Professor`, `Disciplina`, `Turma`, `Coordenador`, `Sala`.

#### Os cinco objetos

- `Biblioteca`
- `Matricula`
- `Horario`
- `Avaliacao`
- `CalendarioAcademico`

### 6. Objetos em um jogo

#### Enunciado
Imagine um jogo qualquer. Identifique o máximo de objetos possíveis e eventuais características (atributos) e comportamentos (métodos) que eles poderiam ter. 

Jogo de vôlei - Atributos: `Duracao,` `Local`, `Tipo`, `QuantidadeDeJogadores`, `Placar`, `Time1`, `Time2`; Métodos: `IniciarPartida`, `Pausar`, `AdicionarJogador`, `RemoverJogador`, `FinalizarPartidas`.

#### Jogo de futebol:
- **Objetos**
  - `Jogador`, `Time`, `Bola`, `Placar`, `Partida`
<br>

- **Atributos**
  - `Jogador`: `Nome`, `Posicao`, `NumeroCamisa`
  - `Time`: `Nome`, `NumeroDeJogadores`, `Tecnico`
  - `Bola`: `Marca`, `Tamanho`, `Peso`
  - `Placar`: `GolsTime1`, `GolsTime2`, `TempoDecorrido`
  - `Partida`: `Duracao`, `Estadio`, `Equipes`
<br>

- **Métodos**
  - `Jogador`: `Chutar()`, `Passar()`, `Driblar()`
  - `Time`: `AdicionarJogador()`, `RemoverJogador()`, `SubstituirJogador()`
  - `Placar`: `AtualizarGols()`, `MostrarPlacar()`
  - `Partida`: `Iniciar()`, `Pausar()`, `Encerrar()`
