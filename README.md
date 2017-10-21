# Merging cells in DataGrid
Possible solution for https://stackoverflow.com/questions/39748090/merging-cells-in-wpf-datagrid-vertically

Requirement is to have tabular view as below
+---------+------+-----+
| Country | Name | Age |
+---------+------+-----+
|         | Lisa | 24  |
+         +------+-----+
| Danmark |  Per | 32  |
+         +------+-----+
|         | Hans | 33  |
+---------+------+-----+
| Germany | Mick | 22  |
+---------+------+-----+

WPF DataGrid do not have feature to merge cell. The demo project do not implement merge but creates a visual effect which can be useful in case similar to explained in above stackoverflow question. This solution makes use of two DataGrids. First DataGrid with one column which has headers and second which has data for headers.
