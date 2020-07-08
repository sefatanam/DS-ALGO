class Node:
    def __init__(self, value):
        self.next = None
        self.prev = None
        self.val = value


class DoubleLinkedList:
    def __init__(self):
        self.head = None
        self.tail = None
        self.size = 0

    def add(self, value):
        node = Node(value)
        if self.tail is None:
            self.head = node
            self.tail = node
            self.size += 1

        else:
            self.tail.next = node
            node.prev = self.tail
            self.tail = node
            self.size += 1

    def __str__(self):
        vals = []
        node = self.head
        while node is not None:
            vals.append(node.val)
            node = node.next
        return f"[{','.join(str(val) for val in vals)}]"

    def __remove_node(self, node):
        if node.prev is None:
            self.head = node.next
        else:
            node.prev.next = node.next
        if node.next is None:
            self.tail = node.prev
        else:
            node.next.prev = node.prev

        self.size -= 1

    def remove(self, value):
        node = self.head
        while node is not None:
            if node.val == value:
                self.__remove_node(node)

            node = node.next

    def remove_last(self):
        if self.tail is not None:
            self.__remove_node(self.tail)

    def remove_first(self):
        if self.head is not None:
            self.__remove_node(self.head)


my_List = DoubleLinkedList()
my_List.add(1)
my_List.add(1)
my_List.add(1)
my_List.add(1)
my_List.add(1)
my_List.add(1)
my_List.add(5)
my_List.add(17)
print(my_List.size)
my_List.remove(17)

print(my_List)
print(my_List.size)
my_List.remove_first()
print(my_List)
print(my_List.size)
