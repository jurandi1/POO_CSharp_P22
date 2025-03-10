<h3> HashSet<T> e SortedSet<T> </h3>
<hr />
  
<h4> HashSet<T> e SortedSet<T> </h4>
  
• Representa um conjunto de elementos (similar ao da Álgebra) 

• Não admite repetições

• Elementos não possuem posição

• Acesso, inserção e remoção de elementos são rápidos

• Oferece operações eficientes de conjunto: interseção, união, diferença. 

• HashSet 

• https://msdn.microsoft.com/en-us/library/bb359438(v=vs.110).aspx

• SortedSet 

• https://msdn.microsoft.com/en-us/library/dd412070(v=vs.110).aspx

<b>Diferenças</b>

<b>• HashSet </b>

• Armazenamento em tabela hash

• Extremamente rápido: inserção, remoção e busca O(1)

• A ordem dos elementos não é garantida


<b>• SortedSet </b>

• Armazenamento em árvore

• Rápido: inserção, remoção e busca O(log(n)) 

• Os elementos são armazenados ordenadamente conforme implementação
IComparer<T>

<b>Alguns métodos importantes</b>

• Add

• Clear

• Contains

• UnionWith(other) - operação união: adiciona no conjunto os elementos do outro conjunto, sem repetição

• IntersectWith(other) - operação interseção: remove do conjunto os elementos não contidos em other 

• ExceptWith(other) - operação diferença: remove do conjunto os elementos contidos em other 

• Remove(T) 

• RemoveWhere(predicate)
