# Reorderable List GUI for Unity (uGUI)

![thumbnail](https://github.com/kodai100/Unity_ReorderableList/blob/master/Thumbnails/thumbnail.png)

# Base classes

- ReorderableList : abstraction of reorderable list
- ReorderableListComponent : abstraction of reorderable list component

These classes must be implemented with your concrete one.

ReorderableList instantiates ReorderableListComponents, so ReorderableList requres ReorderableListComponent prefab.

# Implementation

when you use reorderable list feature, some steps will be needed.

### Define your data model

see SampleData.cs

### Implement your ReorderableList

see SampleList.cs

![list](https://github.com/kodai100/Unity_ReorderableList/blob/master/Thumbnails/list.png)

### Implement your ReorderableListComponent and make a Prefab

see SampleListComponent.cs and SampleListComponent.prefab

![component](https://github.com/kodai100/Unity_ReorderableList/blob/master/Thumbnails/component.png)