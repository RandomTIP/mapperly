﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    private partial ((int, int), int) Map(((int, int), string) source)
    {
        var target = (source.Item1, int.Parse(source.Item2));
        target.Item1.Item1 = int.Parse(source.Item2);
        return target;
    }
}