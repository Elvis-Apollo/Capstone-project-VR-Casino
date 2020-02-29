import tkinter as tk
import json
from tkinter import ttk

'''
Json maker for Admin Portal
'''
class AdminPortalJsonMaker:
    '''
    This class creates a simple json parser gui using tkinter
    '''

    
    def __init__(self, master):
        self.quit = False
        ttk.Label(master, text = 'Admin Portal').pack()
        #####################################################################
        
        # number of wins field
        ttk.Label(master, text = 'Set Number of Wins').pack()
        self.wins = tk.StringVar()
        self.spinbxwin = tk.Spinbox(master, from_ = 0, 
                                 to = 20,
                                 textvariable = self.wins)
        self.spinbxwin.pack()
        
        #####################################################################
        
        # number of losses field
        ttk.Label(master, text = 'Set Number of Losses').pack()
        self.losses = tk.StringVar()
        self.spinbxloss = tk.Spinbox(master, from_ = 0, 
                                 to = 20,
                                 textvariable = self.losses)
        self.spinbxloss.pack()
        
        #####################################################################
        
        # number of nearMisses field
        ttk.Label(master, text = 'Set Number of Near Misses').pack()
        self.nearMisses = tk.StringVar()
        self.spinbxnearmiss = tk.Spinbox(master, from_ = 0, to = 20,
                                     textvariable = self.nearMisses)                                         
        self.spinbxnearmiss.pack()
        
        #################### Message ##############################################
        
        # Display Message at bot
        self.displaymsg = ttk.Label(master, text = "Max 20 per outcome")
        self.displaymsg.pack()

        # Add this to a new func for previewing json
        # data2 = {
        # "NumOfWins": self.wins.get(),
        # "NumOfLosses": self.losses.get(),
        # "NumOfNearMisses": self.nearMisses.get()
        # }
        # self.strr = json.dumps(data2)
        # self.displayjson = ttk.Label(master, text = "Json: " + self.strr )
        # self.displayjson.pack()

        ################# Buttons ################################################

        # Save button
        ttk.Button(master, text = "Save", command = self.saveToJson).pack()

        # Quit button
        ttk.Button(master, text = "Quit", command = quit).pack()
        
    ################ METHODS #################################################### 
    
    # saves the current SpinBox values to a json using the data dict
        

    # writes json to a file on disk
    def saveToJson(self):
        data = {
        "NumOfWins": self.wins.get(),
        "NumOfLosses": self.losses.get(),
        "NumOfNearMisses": self.nearMisses.get()
        } 
        with open('AdminPortal.json', 'w') as f:            
            json.dump(data, f, ensure_ascii=False)       


def launchAdminPortalJsonMakerApp():
    root = tk.Tk()
    AdminPortalJsonMaker(root)
    tk.mainloop()

def test():
    launchAdminPortalJsonMakerApp()

if __name__ == '__main__': test()