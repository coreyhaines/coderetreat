name := "conways-game-of-life-scala"

version := "0.1"

scalaVersion := "2.11.4"

scalacOptions := Seq("-unchecked", "-deprecation", "-encoding", "utf8", "-feature")

resolvers ++= Seq(
  "sonatype releases" at "https://oss.sonatype.org/content/repositories/releases/",
  "sonatype snapshots" at "https://oss.sonatype.org/content/repositories/snapshots/",
  "typesafe repo" at "http://repo.typesafe.com/typesafe/releases/"
)

libraryDependencies ++= Seq(
   "org.specs2"         %   "specs2_2.10"            % "2.3.13"     % "test"
  ,"junit"              %   "junit"                  % "4.11"       % "test"
  ,"org.scalatest"      %   "scalatest_2.11"         % "2.2.1"      % "test"
)