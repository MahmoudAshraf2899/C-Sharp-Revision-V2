using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_DeadLock.Services
{
    internal class TransferManager
    {
        private Wallet from;
        private Wallet to;
        private int amountToTransfer;

        public TransferManager(Wallet from, Wallet to, int amountToTransfer)
        {
            this.from = from;
            this.to = to;
            this.amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock...{from}");
            lock (from)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} Lock acquired...{from}");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock...{to}");
                #region We Comment That To avoid Dead lock
                //lock (to)
                //{
                //    Console.WriteLine($"{Thread.CurrentThread.Name} Lock acquired...{to}");
                //    from.Debit(amountToTransfer);
                //    to.Credit(amountToTransfer);

                //} 
                #endregion
                if (Monitor.TryEnter(to, 1000))
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} Lock acquired...{to}");
                    try
                    {
                        from.Debit(amountToTransfer);
                        to.Credit(amountToTransfer);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        Monitor.Exit(to);
                    }
                }
                else
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} Unable to Lock ...{to}");
                }
            }
            Thread.Sleep(1000);

            Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock...{from}");

        }
    }
}
