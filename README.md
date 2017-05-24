# Immortal

An immortal object resurrects itself by calling GC.ReRegisterForFinalize(this); in it’s finalizer. Every time it is being finalized, the reference on it is removed from fReacable queue and then added there again. In this way an object of Immortal class will newer be garbage collected... until the application domain shutdown.

It says on MSDN: The runtime continues to finalize objects during shutdown only while the number of finalizable objects continues to decrease. After the immortal object has been finalized, there is one object (which is the immortal) is among finalizable objects every time, so the number of finalizable objects does not continue to decrease. Therefore, finalization stops and the object dies.

To verify the said above we need to go deeper in GC algorithms.

Anyway, when the Main method is finished, messages about finalization of the immortal object will continue to appear in console for some time (for that finalizations, which occurred before an application shutdown) and then will stop.
