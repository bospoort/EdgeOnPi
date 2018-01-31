# -*- coding: utf-8 -*-
import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(3, GPIO.OUT)
for x in range(0,4):
    print ("LED On")
    GPIO.output(3, GPIO.HIGH)
    time.sleep(1)
    print "LED off"
    GPIO.output(3, GPIO.LOW)
    time.sleep(1)
print "Done. Bye"