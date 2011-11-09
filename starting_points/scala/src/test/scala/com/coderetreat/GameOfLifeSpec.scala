package com.coderetreat

import org.junit.runner.RunWith
import org.scalatest.junit.JUnitRunner

import org.scalatest.matchers.ShouldMatchers
import org.scalatest.FlatSpec

/**
 * Stub testing class using ScalaTest's FlatSpec. Of course, you are welcome to use a different
 * testing framework, or a different testing style.
 */
@RunWith(classOf[JUnitRunner])
class GameOfLifeSpec extends FlatSpec with ShouldMatchers {
  "True" should "be true" in {
    true should be(false)
  }
}