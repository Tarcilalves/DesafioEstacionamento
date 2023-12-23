# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Tarcilalves_trilha-net-fundamentos-desafio](https://github.com/Tarcilalves/DesafioEstacionamento/assets/107896645/67dde6f8-e38b-4a6d-9b7a-122a7b48261a)


A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Solução Aplicado
> Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos":

<br>


Primeiro pensei em usar o método Dictionary para fazer a ação para incorporar uma coleção de placas como palavra-chaves, mas devido a estrutura já pré estabelicida tive que reformular a ideia. 
- Foi adicionada a linha string? placa = Console.ReadLine(); para obter a placa do usuário.
- Foi adicionada uma verificação if (placa != null) para garantir que a placa não seja nula antes de tentar adicioná-la à lista. Isso evita possíveis problemas caso Console.ReadLine() retorne null.
- Adição da linha placa = placa.ToUpper(); para converter a placa para maiúsculas antes de adicioná-la à lista. Isso garante consistência na comparação de placas, tornando-a insensível a maiúsculas e minúsculas.
- Foi adicionada a linha veiculos.Add(placa); para incluir a placa na lista de veículos.
- Foram adicionadas mensagens informativas para indicar se o veículo foi adicionado com sucesso ou se houve algum problema, como a placa sendo nula.

Para corrigir o aviso CS8604 que indicava que há um possível argumento de referência nula para o método <list>. Para resolver esse problema, torná-la anulável (do tipo string?) em vez de 'string'.
A solução atualizada, fazendo uso de uma lista de strings para armazenar as placas dos veículos. Ela inclui validações adicionais para garantir que a entrada do usuário seja tratada corretamente e proporciona mensagens mais descritivas. A conversão para maiúsculas ajuda a evitar problemas relacionados à entrada de texto com diferentes casos.<br><br>


>Pedir para o usuário digitar a placa e armazenar na variável placa:

<br>

- Foi adicionada a linha string? placa = Console.ReadLine(); para obter a placa do usuário.
- A verificação foi melhorada com veiculos.Any(x => string.Equals(x, placa, StringComparison.InvariantCultureIgnoreCase)), tornando-a mais robusta ao lidar com diferentes culturas e evitando problemas de comparação de strings.
- Foi adicionada a condição if (int.TryParse(Console.ReadLine(), out int horas)) para garantir que o usuário insira um valor numérico válido para as horas.
- Foi adicionado o cálculo decimal valorTotal = precoInicial + precoPorHora * horas; para determinar o valor total com base nas horas estacionadas.
- Foi adicionada a linha veiculos.RemoveAll(x => string.Equals(x, placa, StringComparison.InvariantCultureIgnoreCase)); para remover a placa correta da lista de veículos.
- Adição de uma mensagem de erro para o caso em que a entrada de horas não é válida.
<br>

>Realizar um laço de repetição, exibindo os veículos estacionados
<br>

- Foi adicionado um laço foreach que itera sobre a coleção de veículos e imprime cada veículo na console. Isso torna o código funcional e efetivamente lista os veículos estacionados.
- Foram mantidas as verificações para determinar se há veículos estacionados ou não. Se houver veículos, o código agora exibe a mensagem "Os veículos estacionados são:" antes de listar os veículos. Se não houver veículos, a mensagem "Não há veículos estacionados." é exibida. Isso fornece informações claras sobre o estado do estacionamento.

Essas melhorias tornam o código mais completo e funcional, garantindo que a listagem de veículos seja feita de maneira adequada e que as mensagens de saída sejam informativas para o usuário.




## Programa Estacionamento


https://github.com/Tarcilalves/DesafioEstacionamento/assets/107896645/bc6f7ede-8a28-470e-a1e0-76c41d50a6aa

<br><br>



## Material de Apoio

### Stack Overflow

Encontre ajuda e discussões relacionadas ao projeto no Stack Overflow:

[Stack Overflow](https://stackoverflow.com/)

### ChatGPT

Para obter suporte usando ChatGPT ou discutir ideias, visite o ChatGPT:

[ChatGPT](https://www.chatbot.com/chatgpt)

### Fórum do GitHub

Participe das discussões, faça perguntas e compartilhe suas contribuições no Fórum do GitHub:

[Discussões do Projeto no Fórum do GitHub](https://github.com/seu-usuario/seu-projeto/discussions)

## Contribuição

Saiba como contribuir para este projeto [aqui](CONTRIBUTING.md).

...


