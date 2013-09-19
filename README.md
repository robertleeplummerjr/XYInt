A very simple utility for tracking 2 points in a single integer.

```c#
var x = 8;
var y = 16;

var xyint = new XYInt(x, y);

var newxyint = new XYInt(xyint.Val);

newxyint.X;//equals 8
newxyint.Y;//equals 16
```
