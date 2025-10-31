# Briefing: Árvores Binárias - O que São e Como Funcionam
## O que é uma Árvore Binária
Uma árvore binária é uma estrutura de dados hierárquica composta por nós, onde cada nó possui no máximo dois filhos, geralmente chamados de filho esquerdo e filho direito. O primeiro nó da árvore é chamado de raiz.
## Conceitos Fundamentais
### Terminologia Básica
- **Nó**: Elemento básico que compõe a árvore, contendo um valor e referências para seus filhos.
- **Raiz**: O nó superior da árvore, que não possui pai.
- **Filho**: Nó diretamente conectado abaixo de outro nó.
- **Pai**: Nó que possui conexão direta com outro nó abaixo dele.
- **Folha**: Nó que não possui filhos (nós terminais).
- **Altura**: A distância máxima entre a raiz e qualquer folha.
- **Profundidade**: A distância entre um nó específico e a raiz.
- **Subárvore**: Árvore formada por um nó e todos os seus descendentes.

### Representação Visual

````
       A       ← Raiz
     /   \
    B     C    ← Filhos da raiz
   / \     \
  D   E     F  ← D e E são folhas, F é filho de C
````

# Atividade sobre Árvores Binárias de Números em C#

## Desenho do Esqueleto da Árvore Binária

```
            10
          /    \
        5       15
      /   \    /   \
     3     7  12    18
    / \   /      \    \
   1   4 6       14    20
```

### Implementação de uma Árvore Binária de Busca em C#

Nesta atividade, você deverá implementar uma Árvore Binária de Busca (ABB) para armazenar números inteiros. Uma ABB é uma estrutura de dados na qual cada nó possui no máximo dois filhos (esquerdo e direito), onde todos os valores menores que o valor do nó atual são armazenados na subárvore esquerda e todos os valores maiores são armazenados na subárvore direita.

#### Requisitos:
1. Crie uma classe Node que represente um nó da árvore com as seguintes propriedades:
   - Valor inteiro
   - Referência para o nó filho esquerdo
   - Referência para o nó filho direito

1. Crie uma classe BinarySearchTree que gerencia a árvore e implemente os seguintes métodos:
   - Insert(int value): Insere um novo valor na árvore
   - Search(int value): Verifica se um valor existe na árvore
   - Delete(int value): Remove um valor da árvore
   - InOrderTraversal(): Retorna uma lista com os valores da árvore em ordem crescente
   - GetHeight(): Retorna a altura da árvore

1. Crie um programa de console que demonstre todas as funcionalidades da sua árvore:
   - Inserir vários números
   - Buscar números existentes e inexistentes
   - Remover números
   - Exibir a árvore nos diferentes percursos
   - Mostrar a altura da árvore antes e depois de modificações

Dicas de Construção em C#
Estrutura das Classes

``` csharp
public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    private Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    // Métodos a serem implementados
    public void Insert(int value)
    {
        // Implementar inserção recursiva ou iterativa
    }

    // Demais métodos...
}
```

### Dicas para Implementação

1. Método de Inserção:
    - Verifique se a árvore está vazia; se estiver, crie um novo nó como raiz
    - Caso contrário, compare o valor a ser inserido com o valor do nó atual
    - Se o valor for menor, insira na subárvore esquerda
    - Se o valor for maior, insira na subárvore direita
    - Considere usar uma abordagem recursiva

1. Método de Busca:
    - Compare o valor buscado com o valor do nó atual
    - Se forem iguais, o valor foi encontrado
    - Se for menor, busque na subárvore esquerda
    - Se for maior, busque na subárvore direita
    - Se chegar a um nó nulo, o valor não existe na árvore

1. Método de Remoção (o mais complexo):
    - Caso 1: O nó a ser removido não tem filhos (é uma folha) - simplesmente remova o nó
    - Caso 2: O nó a ser removido tem apenas um filho - substitua o nó pelo seu filho
    - Caso 3: O nó a ser removido tem dois filhos - encontre o sucessor in-order (o menor valor na subárvore direita), substitua o valor do nó a ser removido pelo valor do sucessor, e então remova o sucessor

1. Cálculo da Altura:
    - A altura de uma árvore vazia é -1
    - A altura de um nó folha é 0
    - Para qualquer outro nó, a altura é 1 + o máximo entre as alturas das subárvores esquerda e direita

1. Métodos de Percurso:
    - In-order (em ordem): percorra a subárvore esquerda, visite o nó atual, percorra a subárvore direita

### Sugestão de Teste

1. Insira na ordem: 10, 5, 15, 3, 7, 12, 18, 1, 4, 6, 14, 20
1. Verifique os percursos:
    - In-order (deve ser: 1, 3, 4, 5, 6, 7, 10, 12, 14, 15, 18, 20)
1. Remova o nó 5 e verifique novamente os percursos
