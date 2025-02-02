/**
 * The MIT License (MIT)
 *
 * Copyright (C) 2023 dropbox.com
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

import { RequestFile, AttributeTypeMap, ObjectSerializer } from "./models";
import { TeamParentResponse } from "./teamParentResponse";

export class TeamInfoResponse {
  /**
   * The id of a team
   */
  "teamId"?: string;
  "teamParent"?: TeamParentResponse | null;
  /**
   * The name of a team
   */
  "name"?: string;
  /**
   * Number of members within a team
   */
  "numMembers"?: number;
  /**
   * Number of sub teams within a team
   */
  "numSubTeams"?: number;

  static discriminator: string | undefined = undefined;

  static attributeTypeMap: AttributeTypeMap = [
    {
      name: "teamId",
      baseName: "team_id",
      type: "string",
    },
    {
      name: "teamParent",
      baseName: "team_parent",
      type: "TeamParentResponse",
    },
    {
      name: "name",
      baseName: "name",
      type: "string",
    },
    {
      name: "numMembers",
      baseName: "num_members",
      type: "number",
    },
    {
      name: "numSubTeams",
      baseName: "num_sub_teams",
      type: "number",
    },
  ];

  static getAttributeTypeMap(): AttributeTypeMap {
    return TeamInfoResponse.attributeTypeMap;
  }

  /** Attempt to instantiate and hydrate a new instance of this class */
  static init(data: any): TeamInfoResponse {
    return ObjectSerializer.deserialize(data, "TeamInfoResponse");
  }
}
