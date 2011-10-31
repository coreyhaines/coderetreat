name := "conways-game-of-life-scala"

version := "1.0.0"

organization := "com.coderetreat"

scalaVersion := "2.9.0-1"

// Test dependencies
libraryDependencies ++= Seq(
  "org.scalatest" % "scalatest_2.9.0" % "1.6.1" % "test",
  "org.scala-tools.testing" % "specs" % "1.4.4" % "test",
  "junit" % "junit" % "4.8.2" % "test"
)

resolvers += "Scala-Tools Maven2 Repository" at "http://www.scala-tools.org/repo-releases/"
