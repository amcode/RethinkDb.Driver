




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class Match : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #1
                 //ExpectedOriginal: ({'str':'bcde','groups':[null,{'start':2,'str':'cde','end':5}],'start':1,'end':5})
                 var expected = new MapObject().with("str", "bcde").with("groups", Arrays.asList(null, new MapObject().with("start", 2).with("str", "cde").with("end", 5))).with("start", 1).with("end", 5);
                 
                 //Original: r.expr("abcdefg").match("a(b.e)|b(c.e)")
                 var obtained = runOrCatch( r.expr("abcdefg").match("a(b.e)|b(c.e)") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #2
                 //ExpectedOriginal: (null)
                 var expected = null as object;
                 
                 //Original: r.expr("abcdefg").match("a(b.e)|B(c.e)")
                 var obtained = runOrCatch( r.expr("abcdefg").match("a(b.e)|B(c.e)") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #3
                 //ExpectedOriginal: ({'str':'bcde','groups':[null,{'start':2,'str':'cde','end':5}],'start':1,'end':5})
                 var expected = new MapObject().with("str", "bcde").with("groups", Arrays.asList(null, new MapObject().with("start", 2).with("str", "cde").with("end", 5))).with("start", 1).with("end", 5);
                 
                 //Original: r.expr("abcdefg").match("(?i)a(b.e)|B(c.e)")
                 var obtained = runOrCatch( r.expr("abcdefg").match("(?i)a(b.e)|B(c.e)") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #4
                 //ExpectedOriginal: (["aca", "ada"])
                 var expected = Arrays.asList("aca", "ada");
                 
                 //Original: r.expr(["aba", "aca", "ada", "aea"]).filter(lambda row:row.match("a(.)a")['groups'][0]['str'].match("[cd]"))
                 var obtained = runOrCatch( r.expr(Arrays.asList("aba", "aca", "ada", "aea")).filter(row => row.match("a(.)a").bracket("groups").bracket(0).bracket("str").match("[cd]")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #5
                 //ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':3})
                 var expected = new MapObject().with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 3);
                 
                 //Original: tbl.insert([{'id':0,'a':'abc'},{'id':1,'a':'ab'},{'id':2,'a':'bc'}])
                 var obtained = runOrCatch( tbl.insert(Arrays.asList(new MapObject().with("id", 0).with("a", "abc"), new MapObject().with("id", 1).with("a", "ab"), new MapObject().with("id", 2).with("a", "bc"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #6
                 //ExpectedOriginal: ([{'id':0,'a':'abc'},{'id':1,'a':'ab'},{'id':2,'a':'bc'}])
                 var expected = Arrays.asList(new MapObject().with("id", 0).with("a", "abc"), new MapObject().with("id", 1).with("a", "ab"), new MapObject().with("id", 2).with("a", "bc"));
                 
                 //Original: tbl.filter(lambda row:row['a'].match('b')).order_by('id')
                 var obtained = runOrCatch( tbl.filter(row => row.bracket("a").match("b")).orderBy("id") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #7
                 //ExpectedOriginal: ([{'id':0,'a':'abc'},{'id':1,'a':'ab'}])
                 var expected = Arrays.asList(new MapObject().with("id", 0).with("a", "abc"), new MapObject().with("id", 1).with("a", "ab"));
                 
                 //Original: tbl.filter(lambda row:row['a'].match('ab')).order_by('id')
                 var obtained = runOrCatch( tbl.filter(row => row.bracket("a").match("ab")).orderBy("id") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #8
                 //ExpectedOriginal: ([{'id':1,'a':'ab'}])
                 var expected = Arrays.asList(new MapObject().with("id", 1).with("a", "ab"));
                 
                 //Original: tbl.filter(lambda row:row['a'].match('ab$')).order_by('id')
                 var obtained = runOrCatch( tbl.filter(row => row.bracket("a").match("ab$")).orderBy("id") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #9
                 //ExpectedOriginal: ([])
                 var expected = Arrays.asList();
                 
                 //Original: tbl.filter(lambda row:row['a'].match('^b$')).order_by('id')
                 var obtained = runOrCatch( tbl.filter(row => row.bracket("a").match("^b$")).orderBy("id") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, match.yaml, #10
                 //ExpectedOriginal: err("ReqlQueryLogicError", "Error in regexp `ab\\9` (portion `\\9`): invalid escape sequence: \\9", [])

                 var expected = err("ReqlQueryLogicError", "Error in regexp `ab\\9` (portion `\\9`): invalid escape sequence: \\9", Arrays.asList());
                 
                 //Original: r.expr("").match("ab\\9")
                 var obtained = runOrCatch( r.expr("").match("ab\\9") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}