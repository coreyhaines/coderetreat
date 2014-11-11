package com.coderetreat

import org.junit.runner.RunWith
import org.scalatest.junit.JUnitRunner

import org.scalatest.matchers.ShouldMatchers
import org.scalatest.{FunSuite, FlatSpec}

/**
 * Stub testing class using ScalaTest's FlatSpec. Of course, you are welcome to use a different
 * testing framework, or a different testing style.
 */
@RunWith(classOf[JUnitRunner])
class GameOfLifeSpec extends FunSuite with ShouldMatchers {
  test("True should be true") {
    true should be(false)
  }
}