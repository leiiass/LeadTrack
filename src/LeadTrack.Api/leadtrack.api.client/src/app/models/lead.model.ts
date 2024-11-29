export interface Lead {
    id: number;
    contactFirstName: string;
    contactFullName?: string;
    contactPhoneNumber?: string;
    contactEmail?: string;
    dateCreated: Date;
    suburb: string;
    category: string;
    description: string;
    price: number;
    status?: StatusEnum;
  }
  
  export enum StatusEnum {
    Invited = 0,
    Accepted = 1,
    Declined = 2,
  }
  