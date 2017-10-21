# Merging cells in DataGrid

![alt text](https://github.com/praful-hunde/DataGridDemo/blob/master/Image.png)

Possible solution for https://stackoverflow.com/questions/39748090/merging-cells-in-wpf-datagrid-vertically

WPF DataGrid lacks feature to merge cells. The demo project do not implement merge but creates a visual effect which can be useful in case similar to explained in above stackoverflow question. This solution makes use of two DataGrids. First DataGrid with one column which has row headers and second which has data for headers. This demo is minimal and do not handle cases like synchronizing vertical scroll of two grids, which will be required in real world scenario. 
